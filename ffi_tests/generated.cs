/*! \file */
/*******************************************
 *                                         *
 *  File auto-generated by `::safer_ffi`.  *
 *                                         *
 *  Do not manually edit this file.        *
 *                                         *
 *******************************************/

#pragma warning disable IDE0044, IDE0049, IDE0055, IDE1006,
#pragma warning disable SA1004, SA1008, SA1023, SA1028,
#pragma warning disable SA1121, SA1134,
#pragma warning disable SA1201,
#pragma warning disable SA1300, SA1306, SA1307, SA1310, SA1313,
#pragma warning disable SA1500, SA1505, SA1507,
#pragma warning disable SA1600, SA1601, SA1604, SA1605, SA1611, SA1615, SA1649,

namespace FfiTests {
using System;
using System.Runtime.InteropServices;

public unsafe partial class Ffi {
    private const string RustLib = "ffi_tests";
}

public enum Wow_t : byte {
    Leroy,
    Jenkins,
}

[StructLayout(LayoutKind.Sequential, Size = 1)]
public unsafe struct AnUnusedStruct_t {
    public Wow_t are_you_still_there;
}

public unsafe partial class Ffi {
    public const Int32 FOO = 42;
}

public enum Bar_t : sbyte {
    A = 43,
    B = 42,
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void *
    void_ptr_bool_fptr (
        [MarshalAs(UnmanagedType.U1)]
        bool _0);

/// <summary>
/// Hello, <c>World</c>!
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct next_generation_t {
    /// <summary>
    /// I test some <c>gen</c>-eration.
    /// </summary>
    public Bar_t gen;

    /// <summary>
    /// with function pointers and everything!
    /// </summary>
    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_ptr_bool_fptr cb;
}

/// <summary>
/// Hello, <c>World</c>!
/// </summary>
public enum triforce_t : byte {
    Din = 3,
    Farore = 1,
    Naryu,
}

public unsafe partial class Ffi {
    /// <summary>
    /// https://github.com/getditto/safer_ffi/issues/45
    /// </summary>
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    Int32 _issue_45 (
        Int32 __arg_0);
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    Int32 async_get_ft ();
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void
    void_void_ptr_fptr (
        void * _0);

/// <summary>
/// <c>Arc<dyn Send + Sync + Fn() -> Ret></c>
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 32)]
public unsafe struct ArcDynFn0_void_t {
    public void * env_ptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_fptr call;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_fptr release;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_fptr retain;
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void call_in_the_background (
        ArcDynFn0_void_t f);
}

/// <summary>
/// This is a <c>#[repr(C)]</c> enum, which leads to a classic enum def.
/// </summary>
public enum SomeReprCEnum_t  {
    /// <summary>
    /// This is some variant.
    /// </summary>
    SomeVariant,
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void check_SomeReprCEnum (
        SomeReprCEnum_t _baz);
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void check_bar (
        Bar_t _bar);
}

public unsafe partial class Ffi {
    /// <summary>
    /// Concatenate the two input strings into a new one.
    ///
    /// The returned string must be freed using <c>free_char_p</c>.
    /// </summary>
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    byte * concat (
        byte /*const*/ * fst,
        byte /*const*/ * snd);
}

public unsafe partial class Ffi {
    /// <summary>
    /// Frees a string created by <c>concat</c>.
    /// </summary>
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void free_char_p (
        byte * _string);
}

public struct foo_t {
    #pragma warning disable 0169
    private byte OPAQUE;
    #pragma warning restore 0169
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void free_foo (
        foo_t * foo);
}

/// <summary>
/// <c>&'lt [T]</c> but with a guaranteed <c>#[repr(C)]</c> layout.
///
/// # C layout (for some given type T)
///
/// ```c
/// typedef struct {
/// // Cannot be NULL
/// T * ptr;
/// size_t len;
/// } slice_T;
/// ```
///
/// # Nullable pointer?
///
/// If you want to support the above typedef, but where the <c>ptr</c> field is
/// allowed to be <c>NULL</c> (with the contents of <c>len</c> then being undefined)
/// use the <c>Option< slice_ptr<_> ></c> type.
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct slice_ref_int32_t {
    /// <summary>
    /// Pointer to the first element (if any).
    /// </summary>
    public Int32 /*const*/ * ptr;

    /// <summary>
    /// Element count
    /// </summary>
    public UIntPtr len;
}

public unsafe partial class Ffi {
    /// <summary>
    /// Returns a pointer to the maximum integer of the input slice, or <c>NULL</c> if
    /// it is empty.
    /// </summary>
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    Int32 /*const*/ * max (
        slice_ref_int32_t xs);
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    foo_t * new_foo ();
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    Int32 read_foo (
        foo_t /*const*/ * foo);
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    UInt16
    uint16_uint8_fptr (
        byte _0);

public unsafe partial class Ffi {
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    uint16_uint8_fptr returns_a_fn_ptr ();
}

/// <summary>
/// The layout of <c>core::task::wake::Context</c> is opaque/subject to changes.
/// </summary>
public struct Opaque_Context_t {
    #pragma warning disable 0169
    private byte OPAQUE;
    #pragma warning restore 0169
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    ArcDynFn0_void_t rust_future_task_context_get_waker (
        Opaque_Context_t /*const*/ * task_context);
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void rust_future_task_context_wake (
        Opaque_Context_t /*const*/ * task_context);
}

public struct Erased_t {
    #pragma warning disable 0169
    private byte OPAQUE;
    #pragma warning restore 0169
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void
    void_Erased_ptr_fptr (
        Erased_t * _0);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    Erased_t *
    Erased_ptr_Erased_const_ptr_fptr (
        Erased_t /*const*/ * _0);

/// <summary>
/// An FFI-safe <c>Poll<()></c>.
/// </summary>
public enum PollFuture_t : sbyte {
    Completed = 0,
    Pending = -1,
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    PollFuture_t
    PollFuture_Erased_ptr_Opaque_Context_ptr_fptr (
        Erased_t * _0,
        Opaque_Context_t * _1);

[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct FfiFutureVTable_t {
    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_Erased_ptr_fptr release_vptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public PollFuture_Erased_ptr_Opaque_Context_ptr_fptr dyn_poll;
}

[StructLayout(LayoutKind.Sequential, Size = 24)]
public unsafe struct VirtualPtr__Erased_ptr_FfiFutureVTable_t {
    public Erased_t * ptr;

    public FfiFutureVTable_t vtable;
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    VirtualPtr__Erased_ptr_FfiFutureVTable_t
    VirtualPtr__Erased_ptr_FfiFutureVTable_Erased_const_ptr_VirtualPtr__Erased_ptr_FfiFutureVTable_fptr (
        Erased_t /*const*/ * _0,
        VirtualPtr__Erased_ptr_FfiFutureVTable_t _1);

/// <summary>
/// <c>Box<dyn 'static + Send + FnMut() -> Ret></c>
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 24)]
public unsafe struct BoxDynFnMut0_void_t {
    public void * env_ptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_fptr call;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_fptr free;
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    VirtualPtr__Erased_ptr_FfiFutureVTable_t
    VirtualPtr__Erased_ptr_FfiFutureVTable_Erased_const_ptr_BoxDynFnMut0_void_fptr (
        Erased_t /*const*/ * _0,
        BoxDynFnMut0_void_t _1);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void
    void_Erased_const_ptr_VirtualPtr__Erased_ptr_FfiFutureVTable_fptr (
        Erased_t /*const*/ * _0,
        VirtualPtr__Erased_ptr_FfiFutureVTable_t _1);

[StructLayout(LayoutKind.Sequential, Size = 8)]
public unsafe struct DropGlueVTable_t {
    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_Erased_ptr_fptr release_vptr;
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct VirtualPtr__Erased_ptr_DropGlueVTable_t {
    public Erased_t * ptr;

    public DropGlueVTable_t vtable;
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    VirtualPtr__Erased_ptr_DropGlueVTable_t
    VirtualPtr__Erased_ptr_DropGlueVTable_Erased_const_ptr_fptr (
        Erased_t /*const*/ * _0);

[StructLayout(LayoutKind.Sequential, Size = 48)]
public unsafe struct FfiFutureExecutorVTable_t {
    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_Erased_ptr_fptr release_vptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public Erased_ptr_Erased_const_ptr_fptr retain_vptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public VirtualPtr__Erased_ptr_FfiFutureVTable_Erased_const_ptr_VirtualPtr__Erased_ptr_FfiFutureVTable_fptr dyn_spawn;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public VirtualPtr__Erased_ptr_FfiFutureVTable_Erased_const_ptr_BoxDynFnMut0_void_fptr dyn_spawn_blocking;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_Erased_const_ptr_VirtualPtr__Erased_ptr_FfiFutureVTable_fptr dyn_block_on;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public VirtualPtr__Erased_ptr_DropGlueVTable_Erased_const_ptr_fptr dyn_enter;
}

[StructLayout(LayoutKind.Sequential, Size = 56)]
public unsafe struct VirtualPtr__Erased_ptr_FfiFutureExecutorVTable_t {
    public Erased_t * ptr;

    public FfiFutureExecutorVTable_t vtable;
}

public unsafe partial class Ffi {
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    Int32 test_spawner (
        VirtualPtr__Erased_ptr_FfiFutureExecutorVTable_t executor);
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void
    void_void_ptr_char_const_ptr_fptr (
        void * _0,
        byte /*const*/ * _1);

/// <summary>
/// <c>&'lt mut (dyn 'lt + Send + FnMut(A1) -> Ret)</c>
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct RefDynFnMut1_void_char_const_ptr_t {
    public void * env_ptr;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public void_void_ptr_char_const_ptr_fptr call;
}

public unsafe partial class Ffi {
    /// <summary>
    /// Same as <c>concat</c>, but with a callback-based API to auto-free the created
    /// string.
    /// </summary>
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    void with_concat (
        byte /*const*/ * fst,
        byte /*const*/ * snd,
        RefDynFnMut1_void_char_const_ptr_t cb);
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe /* static */ delegate
    void
    void_foo_ptr_fptr (
        foo_t * _0);

public unsafe partial class Ffi {
    [return: MarshalAs(UnmanagedType.U1)]
    [DllImport(RustLib, ExactSpelling = true)] public static unsafe extern
    bool with_foo (
        [MarshalAs(UnmanagedType.FunctionPtr)]
        void_foo_ptr_fptr cb);
}


} /* FfiTests */
