using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014EA RID: 5354
	[Token(Token = "0x20014EA")]
	public class SDKGameBI : Singleton<SDKGameBI>
	{
		// Token: 0x06007B74 RID: 31604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B74")]
		[Address(RVA = "0x27437D0", Offset = "0x27423D0", VA = "0x1827437D0")]
		private SDKGameBI()
		{
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B75")]
		[Address(RVA = "0x27432A0", Offset = "0x2741EA0", VA = "0x1827432A0")]
		public void U8Login()
		{
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B76")]
		[Address(RVA = "0x2742E40", Offset = "0x2741A40", VA = "0x182742E40")]
		public void GSLogin()
		{
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B77")]
		[Address(RVA = "0x2742F70", Offset = "0x2741B70", VA = "0x182742F70")]
		public void StartGame()
		{
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B78")]
		[Address(RVA = "0x2742FD0", Offset = "0x2741BD0", VA = "0x182742FD0")]
		public void StopGame()
		{
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B79")]
		[Address(RVA = "0x2743030", Offset = "0x2741C30", VA = "0x182743030")]
		public void SysInit()
		{
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x00037170 File Offset: 0x00035370
		[Token(Token = "0x6007B7A")]
		[Address(RVA = "0x27433A0", Offset = "0x2741FA0", VA = "0x1827433A0")]
		private static bool _IsSysEnabled()
		{
			return default(bool);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B7B")]
		[Address(RVA = "0x2743630", Offset = "0x2742230", VA = "0x182743630")]
		private void _SetData(int data, object param)
		{
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B7C")]
		[Address(RVA = "0x2743490", Offset = "0x2742090", VA = "0x182743490")]
		private string _LoadDeviceSoC()
		{
			return null;
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B7D")]
		[Address(RVA = "0x2743420", Offset = "0x2742020", VA = "0x182743420")]
		private string _LoadDeviceGraphicsName()
		{
			return null;
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B7E")]
		[Address(RVA = "0x2743500", Offset = "0x2742100", VA = "0x182743500")]
		private void _LoadEmulatorAndVersion(out string emulator, out string version)
		{
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x00037188 File Offset: 0x00035388
		[Token(Token = "0x6007B7F")]
		[Address(RVA = "0x27435D0", Offset = "0x27421D0", VA = "0x1827435D0")]
		private bool _LoadIsIOSAppOnMac()
		{
			return default(bool);
		}

		// Token: 0x040079C5 RID: 31173
		[Token(Token = "0x40079C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040079C6 RID: 31174
		[Token(Token = "0x40079C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_U8Login;

		// Token: 0x040079C7 RID: 31175
		[Token(Token = "0x40079C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GSLogin;

		// Token: 0x040079C8 RID: 31176
		[Token(Token = "0x40079C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StartGame;

		// Token: 0x040079C9 RID: 31177
		[Token(Token = "0x40079C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopGame;

		// Token: 0x040079CA RID: 31178
		[Token(Token = "0x40079CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SysInit;

		// Token: 0x040079CB RID: 31179
		[Token(Token = "0x40079CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsSysEnabled;

		// Token: 0x040079CC RID: 31180
		[Token(Token = "0x40079CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x040079CD RID: 31181
		[Token(Token = "0x40079CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadDeviceSoC;

		// Token: 0x040079CE RID: 31182
		[Token(Token = "0x40079CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadDeviceGraphicsName;

		// Token: 0x040079CF RID: 31183
		[Token(Token = "0x40079CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadEmulatorAndVersion;

		// Token: 0x040079D0 RID: 31184
		[Token(Token = "0x40079D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadIsIOSAppOnMac;

		// Token: 0x020014EB RID: 5355
		[Token(Token = "0x20014EB")]
		private class U8LoginParam
		{
			// Token: 0x06007B80 RID: 31616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B80")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public U8LoginParam()
			{
			}

			// Token: 0x040079D1 RID: 31185
			[Token(Token = "0x40079D1")]
			[FieldOffset(Offset = "0x10")]
			public string userId;
		}

		// Token: 0x020014EC RID: 5356
		[Token(Token = "0x20014EC")]
		private class GSLoginParam
		{
			// Token: 0x06007B81 RID: 31617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B81")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GSLoginParam()
			{
			}

			// Token: 0x040079D2 RID: 31186
			[Token(Token = "0x40079D2")]
			[FieldOffset(Offset = "0x10")]
			public string roleId;

			// Token: 0x040079D3 RID: 31187
			[Token(Token = "0x40079D3")]
			[FieldOffset(Offset = "0x18")]
			public string serverId;
		}

		// Token: 0x020014ED RID: 5357
		[Token(Token = "0x20014ED")]
		private class InitParam
		{
			// Token: 0x06007B82 RID: 31618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B82")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InitParam()
			{
			}

			// Token: 0x040079D4 RID: 31188
			[Token(Token = "0x40079D4")]
			[FieldOffset(Offset = "0x10")]
			public string graphicsName;

			// Token: 0x040079D5 RID: 31189
			[Token(Token = "0x40079D5")]
			[FieldOffset(Offset = "0x18")]
			public string soc;

			// Token: 0x040079D6 RID: 31190
			[Token(Token = "0x40079D6")]
			[FieldOffset(Offset = "0x20")]
			public string emulator;

			// Token: 0x040079D7 RID: 31191
			[Token(Token = "0x40079D7")]
			[FieldOffset(Offset = "0x28")]
			public string emulator_ver;

			// Token: 0x040079D8 RID: 31192
			[Token(Token = "0x40079D8")]
			[FieldOffset(Offset = "0x30")]
			public bool is_ios_app_on_mac;
		}
	}
}
