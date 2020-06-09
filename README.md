<span style="text-align: center;">

![safer-ffi-banner](
https://github.com/getditto/safer_ffi/blob/banner/guide/assets/safer_ffi.jpg?raw=true)

[![CI](
https://github.com/getditto/safer_ffi/workflows/CI/badge.svg?branch=master)](
https://github.com/getditto/safer_ffi/actions)
[![guide](https://img.shields.io/badge/guide-mdbook-blue)](
https://getditto.github.io/safer_ffi)
[![docs-rs](https://docs.rs/safer-ffi/badge.svg)](
https://getditto.github.io/safer_ffi/rustdoc/safer_ffi)
[![crates-io](https://img.shields.io/crates/v/safer-ffi.svg)](
https://crates.io/crates/safer-ffi)
[![repository](https://img.shields.io/badge/repository-GitHub-brightgreen.svg)](
https://github.com/getditto/safer_ffi)

</span>

# The User Guide

The recommended way to learn about `::safer_ffi` is through the user guide:

> [**📚 Read the `::safer_ffi` User guide here📚**][user guide]

[user guide]: https://getditto.github.io/safer_ffi

## Prerequisites

Minimum Supported Rust Version: `1.43.0`

## Quickstart

### `Cargo.toml`

Edit your `Cargo.toml` like so:

```toml
[package]
name = "crate_name"
version = "0.1.0"
edition = "2018"

[lib]
crate-type = ["staticlib"]

[dependencies]
safer-ffi = { version = "*", features = ["proc_macros"] }

[features]
c-headers = ["safer-ffi/headers"]
```

  - Where `"*"` ought to be replaced by the last released version, which you
    can find by running `cargo search safer-ffi`.

### `src/lib.rs`

```rust,ignore
use ::safer_ffi::prelude::*;

/// A `struct` usable from both Rust and C
#[derive_ReprC]
#[repr(C)]
#[derive(Debug, Clone, Copy)]
pub
struct Point {
    x: f64,
    y: f64,
}

/* Export a Rust function to the C world. */
/// Returns the middle point of `[a, b]`.
#[ffi_export]
fn mid_point (
    a: &Point,
    b: &Point,
) -> Point
{
    Point {
        x: (a.x + b.x) / 2.,
        y: (a.y + b.y) / 2.,
    }
}

/// Pretty-prints a point using Rust's formatting logic.
#[ffi_export]
fn print_point (point: &Point)
{
    println!("{:?}", point);
}

/// The following test function is necessary for the header generation.
#[::safer_ffi::cfg_headers]
#[test]
fn generate_headers () -> ::std::io::Result<()>
{
    ::safer_ffi::headers::builder()
        .to_file("rust_points.h")?
        .generate()
}
```

### Compilation & header generation

```bash
# Compile the C library (in `target/{debug,release}/libcrate_name.ext`)
cargo build # --release

# Generate the C header
cargo test --features c-headers -- generate_headers
```

<details><summary>Generated C header</summary>

```C
/*! \file */
/*******************************************
 *                                         *
 *  File auto-generated by `::safer_ffi`.  *
 *                                         *
 *  Do not manually edit this file.        *
 *                                         *
 *******************************************/

#ifndef __RUST_CRATE_NAME__
#define __RUST_CRATE_NAME__

#ifdef __cplusplus
extern "C" {
#endif

/** \brief
 *  A `struct` usable from both Rust and C
 */
typedef struct {

    double x;

    double y;

} Point_t;

/** \brief
 *  Returns the middle point of `[a, b]`.
 */
Point_t mid_point (
    Point_t const * a,
    Point_t const * b);

/** \brief
 *  Pretty-prints a point using Rust's formatting logic.
 */
void print_point (
    Point_t const * point);


#ifdef __cplusplus
} /* extern "C" */
#endif

#endif /* __RUST_CRATE_NAME__ */
```

</details>

### Testing it

#### `main.c`

```C
#include <stdlib.h>

#include "rust_points.h"

int main (int argc, char const * const argv[])
{
    Point_t a = { .x = 84, .y = 45 };
    Point_t b = { .x = 0, .y = 39 };
    Point_t m = mid_point(&a, &b);
    print_point(&m);
    return EXIT_SUCCESS;
}
```

#### Compilation command

```bash
cc main.c -o main -L target/debug -l crate_name

# Now feel free to run the compiled binary
./main
```

which outputs:

```text
Point { x: 42.0, y: 42.0 }
```

🚀🚀
