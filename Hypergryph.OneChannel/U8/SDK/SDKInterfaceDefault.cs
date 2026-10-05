using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class SDKInterfaceDefault : U8SDKInterface
	{
		// Token: 0x06000203 RID: 515 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4A14D10", Offset = "0x4A13910", VA = "0x184A14D10", Slot = "4")]
		protected override string LoadExtraConfig()
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3E806B0", Offset = "0x3E7F2B0", VA = "0x183E806B0", Slot = "5")]
		protected override void V2Init(string env)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4A14B10", Offset = "0x4A13710", VA = "0x184A14B10", Slot = "6")]
		protected override void Init()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4A14E20", Offset = "0x4A13A20", VA = "0x184A14E20", Slot = "7")]
		protected override void Login()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4A14DD0", Offset = "0x4A139D0", VA = "0x184A14DD0", Slot = "8")]
		protected override void LoginCustom(string customData)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4A15040", Offset = "0x4A13C40", VA = "0x184A15040", Slot = "9")]
		protected override void SwitchLogin()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4A14E70", Offset = "0x4A13A70", VA = "0x184A14E70", Slot = "10")]
		protected override bool Logout()
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4A14F60", Offset = "0x4A13B60", VA = "0x184A14F60", Slot = "11")]
		public override bool ShowAccountCenter()
		{
			return default(bool);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4A14FB0", Offset = "0x4A13BB0", VA = "0x184A14FB0", Slot = "12")]
		public override void SubmitGameDataNative(U8ExtraGameData data)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x4A14F10", Offset = "0x4A13B10", VA = "0x184A14F10", Slot = "13")]
		public override bool SDKExit()
		{
			return default(bool);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4A14EC0", Offset = "0x4A13AC0", VA = "0x184A14EC0", Slot = "14")]
		protected override void Pay(U8PayParams data)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4A14C70", Offset = "0x4A13870", VA = "0x184A14C70", Slot = "18")]
		public override bool IsSupportLogin()
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4A14C20", Offset = "0x4A13820", VA = "0x184A14C20", Slot = "15")]
		public override bool IsSupportExit()
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4A14BD0", Offset = "0x4A137D0", VA = "0x184A14BD0", Slot = "16")]
		public override bool IsSupportAccountCenter()
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4A14CC0", Offset = "0x4A138C0", VA = "0x184A14CC0", Slot = "17")]
		public override bool IsSupportLogout()
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public override void SetDataNative(int type, string paramJson)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4A14AD0", Offset = "0x4A136D0", VA = "0x184A14AD0", Slot = "20")]
		public override string GetDataNative(int type, string paramJson)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4A14D80", Offset = "0x4A13980", VA = "0x184A14D80", Slot = "21")]
		protected override SDKMeta LoadSDKMeta()
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "22")]
		protected override bool IsNativePlugin()
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		public override void SetGameVersion(string version)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4A15090", Offset = "0x4A13C90", VA = "0x184A15090")]
		public SDKInterfaceDefault()
		{
		}
	}
}
