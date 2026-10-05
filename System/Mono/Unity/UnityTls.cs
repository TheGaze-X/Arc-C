using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Unity
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal static class UnityTls
	{
		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4F66A50", Offset = "0x4F65650", VA = "0x184F66A50")]
		[MethodImpl(4096)]
		private static extern IntPtr GetUnityTlsInterface();

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000008")]
		public static bool IsSupported
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4F66A60", Offset = "0x4F65660", VA = "0x184F66A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public static UnityTls.unitytls_interface_struct NativeInterface
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x4F66A80", Offset = "0x4F65680", VA = "0x184F66A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityTls.unitytls_interface_struct marshalledInterface;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public enum unitytls_error_code : uint
		{
			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			UNITYTLS_SUCCESS,
			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			UNITYTLS_INVALID_STATE,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		public struct unitytls_errorstate
		{
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint magic;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_error_code code;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ulong reserved;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public struct unitytls_key
		{
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public struct unitytls_key_ref
		{
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public struct unitytls_x509_ref
		{
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public struct unitytls_x509list
		{
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public struct unitytls_x509list_ref
		{
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong handle;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		[Flags]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600002B RID: 43
		[Token(Token = "0x2000013")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		public struct unitytls_tlsctx
		{
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		public struct unitytls_x509name
		{
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public enum unitytls_protocol : uint
		{
			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_protocol min;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600002D RID: 45
		[Token(Token = "0x2000019")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate IntPtr unitytls_tlsctx_write_callback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600002F RID: 47
		[Token(Token = "0x200001A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate IntPtr unitytls_tlsctx_read_callback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000031 RID: 49
		[Token(Token = "0x200001B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void unitytls_tlsctx_trace_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000033 RID: 51
		[Token(Token = "0x200001C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void unitytls_tlsctx_certificate_callback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000035 RID: 53
		[Token(Token = "0x200001D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_x509verify_callback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState);

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public struct unitytls_tlsctx_callbacks
		{
			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnityTls.unitytls_tlsctx_read_callback read;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UnityTls.unitytls_tlsctx_write_callback write;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public unsafe void* data;
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		[StructLayout(0)]
		public class unitytls_interface_struct
		{
			// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public unitytls_interface_struct()
			{
			}

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly ulong UNITYTLS_INVALID_HANDLE;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;

			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;

			// Token: 0x02000020 RID: 32
			// (Invoke) Token: 0x06000038 RID: 56
			[Token(Token = "0x2000020")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate UnityTls.unitytls_errorstate unitytls_errorstate_create_t();

			// Token: 0x02000021 RID: 33
			// (Invoke) Token: 0x0600003A RID: 58
			[Token(Token = "0x2000021")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_errorstate_raise_error_t(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode);

			// Token: 0x02000022 RID: 34
			// (Invoke) Token: 0x0600003C RID: 60
			[Token(Token = "0x2000022")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key_ref unitytls_key_get_ref_t(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000023 RID: 35
			// (Invoke) Token: 0x0600003E RID: 62
			[Token(Token = "0x2000023")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_der_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000024 RID: 36
			// (Invoke) Token: 0x06000040 RID: 64
			[Token(Token = "0x2000024")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_pem_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000025 RID: 37
			// (Invoke) Token: 0x06000042 RID: 66
			[Token(Token = "0x2000025")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_key_free_t(UnityTls.unitytls_key* key);

			// Token: 0x02000026 RID: 38
			// (Invoke) Token: 0x06000044 RID: 68
			[Token(Token = "0x2000026")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_x509_export_der_t(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000027 RID: 39
			// (Invoke) Token: 0x06000046 RID: 70
			[Token(Token = "0x2000027")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509list_ref unitytls_x509list_get_ref_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000028 RID: 40
			// (Invoke) Token: 0x06000048 RID: 72
			[Token(Token = "0x2000028")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509_ref unitytls_x509list_get_x509_t(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000029 RID: 41
			// (Invoke) Token: 0x0600004A RID: 74
			[Token(Token = "0x2000029")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509list* unitytls_x509list_create_t(UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002A RID: 42
			// (Invoke) Token: 0x0600004C RID: 76
			[Token(Token = "0x200002A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002B RID: 43
			// (Invoke) Token: 0x0600004E RID: 78
			[Token(Token = "0x200002B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_der_t(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002C RID: 44
			// (Invoke) Token: 0x06000050 RID: 80
			[Token(Token = "0x200002C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_free_t(UnityTls.unitytls_x509list* list);

			// Token: 0x0200002D RID: 45
			// (Invoke) Token: 0x06000052 RID: 82
			[Token(Token = "0x200002D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_default_ca_t(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002E RID: 46
			// (Invoke) Token: 0x06000054 RID: 84
			[Token(Token = "0x200002E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_explicit_ca_t(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002F RID: 47
			// (Invoke) Token: 0x06000056 RID: 86
			[Token(Token = "0x200002F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_server_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000030 RID: 48
			// (Invoke) Token: 0x06000058 RID: 88
			[Token(Token = "0x2000030")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_client_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000031 RID: 49
			// (Invoke) Token: 0x0600005A RID: 90
			[Token(Token = "0x2000031")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_server_require_client_authentication_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000032 RID: 50
			// (Invoke) Token: 0x0600005C RID: 92
			[Token(Token = "0x2000032")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_certificate_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000033 RID: 51
			// (Invoke) Token: 0x0600005E RID: 94
			[Token(Token = "0x2000033")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_trace_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000034 RID: 52
			// (Invoke) Token: 0x06000060 RID: 96
			[Token(Token = "0x2000034")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_x509verify_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000035 RID: 53
			// (Invoke) Token: 0x06000062 RID: 98
			[Token(Token = "0x2000035")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_supported_ciphersuites_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000036 RID: 54
			// (Invoke) Token: 0x06000064 RID: 100
			[Token(Token = "0x2000036")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_ciphersuite unitytls_tlsctx_get_ciphersuite_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000037 RID: 55
			// (Invoke) Token: 0x06000066 RID: 102
			[Token(Token = "0x2000037")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_protocol unitytls_tlsctx_get_protocol_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000038 RID: 56
			// (Invoke) Token: 0x06000068 RID: 104
			[Token(Token = "0x2000038")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_process_handshake_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000039 RID: 57
			// (Invoke) Token: 0x0600006A RID: 106
			[Token(Token = "0x2000039")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_read_t(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003A RID: 58
			// (Invoke) Token: 0x0600006C RID: 108
			[Token(Token = "0x200003A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_write_t(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003B RID: 59
			// (Invoke) Token: 0x0600006E RID: 110
			[Token(Token = "0x200003B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_notify_close_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003C RID: 60
			// (Invoke) Token: 0x06000070 RID: 112
			[Token(Token = "0x200003C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_free_t(UnityTls.unitytls_tlsctx* ctx);

			// Token: 0x0200003D RID: 61
			// (Invoke) Token: 0x06000072 RID: 114
			[Token(Token = "0x200003D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_random_generate_bytes_t(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);
		}
	}
}
