using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class WindowsIdentity : System.Security.Claims.ClaimsIdentity, IIdentity, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable, System.IDisposable
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x4B69AE0", Offset = "0x4B686E0", VA = "0x184B69AE0")]
		public WindowsIdentity(System.IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x4B69B90", Offset = "0x4B68790", VA = "0x184B69B90")]
		public WindowsIdentity(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x4B69BE0", Offset = "0x4B687E0", VA = "0x184B69BE0")]
		internal WindowsIdentity(System.Security.Claims.ClaimsIdentity claimsIdentity, System.IntPtr userToken)
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x4B69250", Offset = "0x4B67E50", VA = "0x184B69250", Slot = "15")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public void Dispose()
		{
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x4B692A0", Offset = "0x4B67EA0", VA = "0x184B692A0")]
		public static WindowsIdentity GetCurrent()
		{
			return null;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x4B69390", Offset = "0x4B67F90", VA = "0x184B69390", Slot = "16")]
		public virtual WindowsImpersonationContext Impersonate()
		{
			return null;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000325")]
		public sealed override string AuthenticationType
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000326")]
		public override string Name
		{
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x4B69C70", Offset = "0x4B68870", VA = "0x184B69C70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x4B695E0", Offset = "0x4B681E0", VA = "0x184B695E0", Slot = "13")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x4B69940", Offset = "0x4B68540", VA = "0x184B69940", Slot = "14")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x4B69240", Offset = "0x4B67E40", VA = "0x184B69240")]
		internal System.Security.Claims.ClaimsIdentity CloneAsBase()
		{
			return null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
		internal System.IntPtr GetTokenInternal()
		{
			return 0;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x4B69460", Offset = "0x4B68060", VA = "0x184B69460")]
		private void SetToken(System.IntPtr token)
		{
		}

		// Token: 0x06001C11 RID: 7185
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x4B69290", Offset = "0x4B67E90", VA = "0x184B69290")]
		[MethodImpl(4096)]
		internal static extern System.IntPtr GetCurrentToken();

		// Token: 0x06001C12 RID: 7186
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x4B69380", Offset = "0x4B67F80", VA = "0x184B69380")]
		[MethodImpl(4096)]
		private static extern string GetTokenName(System.IntPtr token);

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private System.IntPtr _token;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _type;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WindowsAccountType _account;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _authenticated;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _name;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private System.Runtime.Serialization.SerializationInfo _info;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.IntPtr invalidWindows;
	}
}
