using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[MonoTODO("CAS support is experimental (and unsupported).")]
	[System.Serializable]
	public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CodeAccessPermission()
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x4B0ACD0", Offset = "0x4B098D0", VA = "0x184B0ACD0", Slot = "7")]
		[System.Diagnostics.Conditional("MONO_FEATURE_CAS")]
		public void Demand()
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x4B0AEB0", Offset = "0x4B09AB0", VA = "0x184B0AEB0", Slot = "0")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0", Slot = "2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600178D RID: 6029
		[Token(Token = "0x600178D")]
		public abstract bool IsSubsetOf(IPermission target);

		// Token: 0x0600178E RID: 6030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x4B0B0B0", Offset = "0x4B09CB0", VA = "0x184B0B0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600178F RID: 6031
		[Token(Token = "0x600178F")]
		public abstract SecurityElement ToXml();

		// Token: 0x06001790 RID: 6032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x4B0AD00", Offset = "0x4B09900", VA = "0x184B0AD00")]
		internal SecurityElement Element(int version)
		{
			return null;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x4B0AC10", Offset = "0x4B09810", VA = "0x184B0AC10")]
		internal static System.Security.Permissions.PermissionState CheckPermissionState(System.Security.Permissions.PermissionState state, bool allowUnrestricted)
		{
			return System.Security.Permissions.PermissionState.None;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x4B0B000", Offset = "0x4B09C00", VA = "0x184B0B000")]
		internal static void ThrowInvalidPermission(IPermission target, System.Type expected)
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		private void Demand()
		{
		}
	}
}
