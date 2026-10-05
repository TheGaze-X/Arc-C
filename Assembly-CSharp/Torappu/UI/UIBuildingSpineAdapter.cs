using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200385B RID: 14427
	[Token(Token = "0x200385B")]
	public class UIBuildingSpineAdapter : UISpineHolder.Adapter, IHotfixable
	{
		// Token: 0x06016DA0 RID: 93600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DA0")]
		[Address(RVA = "0xF3F0C0", Offset = "0xF3DCC0", VA = "0x180F3F0C0")]
		public void UpdateParam(UIBuildingSpineAdapter.BuildingSpineInput input)
		{
		}

		// Token: 0x06016DA1 RID: 93601 RVA: 0x00093420 File Offset: 0x00091620
		[Token(Token = "0x6016DA1")]
		[Address(RVA = "0xF3EF60", Offset = "0xF3DB60", VA = "0x180F3EF60", Slot = "4")]
		public override UISpineHolder.SpineID GetSpineID()
		{
			return default(UISpineHolder.SpineID);
		}

		// Token: 0x06016DA2 RID: 93602 RVA: 0x00093438 File Offset: 0x00091638
		[Token(Token = "0x6016DA2")]
		[Address(RVA = "0xF3F000", Offset = "0xF3DC00", VA = "0x180F3F000", Slot = "5")]
		public override Misc.TRS GetTransformParam()
		{
			return default(Misc.TRS);
		}

		// Token: 0x06016DA3 RID: 93603 RVA: 0x00093450 File Offset: 0x00091650
		[Token(Token = "0x6016DA3")]
		[Address(RVA = "0xF3EE50", Offset = "0xF3DA50", VA = "0x180F3EE50", Slot = "6")]
		public override UISpineHolder.SpineAnimParam GetAnimParam()
		{
			return default(UISpineHolder.SpineAnimParam);
		}

		// Token: 0x06016DA4 RID: 93604 RVA: 0x00093468 File Offset: 0x00091668
		[Token(Token = "0x6016DA4")]
		[Address(RVA = "0xF3EDA0", Offset = "0xF3D9A0", VA = "0x180F3EDA0", Slot = "8")]
		public override bool EnableReverseMode(string animName)
		{
			return default(bool);
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DA5")]
		[Address(RVA = "0xF3F190", Offset = "0xF3DD90", VA = "0x180F3F190")]
		public UIBuildingSpineAdapter()
		{
		}

		// Token: 0x06016DA6 RID: 93606 RVA: 0x00093480 File Offset: 0x00091680
		[Token(Token = "0x6016DA6")]
		[Address(RVA = "0xF3EC30", Offset = "0xF3D830", VA = "0x180F3EC30")]
		private Misc.TRS <>xLuaBaseProxy_GetTransformParam()
		{
			return default(Misc.TRS);
		}

		// Token: 0x06016DA7 RID: 93607 RVA: 0x00093498 File Offset: 0x00091698
		[Token(Token = "0x6016DA7")]
		[Address(RVA = "0xF3F0B0", Offset = "0xF3DCB0", VA = "0x180F3F0B0")]
		private bool <>xLuaBaseProxy_EnableReverseMode(string P0)
		{
			return default(bool);
		}

		// Token: 0x0401B8F4 RID: 112884
		[Token(Token = "0x401B8F4")]
		[FieldOffset(Offset = "0x48")]
		private UIBuildingSpineAdapter.BuildingSpineInput m_cachedInput;

		// Token: 0x0401B8F5 RID: 112885
		[Token(Token = "0x401B8F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateParam;

		// Token: 0x0401B8F6 RID: 112886
		[Token(Token = "0x401B8F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSpineID;

		// Token: 0x0401B8F7 RID: 112887
		[Token(Token = "0x401B8F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTransformParam;

		// Token: 0x0401B8F8 RID: 112888
		[Token(Token = "0x401B8F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAnimParam;

		// Token: 0x0401B8F9 RID: 112889
		[Token(Token = "0x401B8F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EnableReverseMode;

		// Token: 0x0401B8FA RID: 112890
		[Token(Token = "0x401B8FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200385C RID: 14428
		[Token(Token = "0x200385C")]
		public struct BuildingSpineInput
		{
			// Token: 0x0401B8FB RID: 112891
			[Token(Token = "0x401B8FB")]
			[FieldOffset(Offset = "0x0")]
			public string skinId;

			// Token: 0x0401B8FC RID: 112892
			[Token(Token = "0x401B8FC")]
			[FieldOffset(Offset = "0x8")]
			public bool overrideTransform;

			// Token: 0x0401B8FD RID: 112893
			[Token(Token = "0x401B8FD")]
			[FieldOffset(Offset = "0xC")]
			public Misc.TRS transformParam;

			// Token: 0x0401B8FE RID: 112894
			[Token(Token = "0x401B8FE")]
			[FieldOffset(Offset = "0x34")]
			public bool overrideAnimParam;

			// Token: 0x0401B8FF RID: 112895
			[Token(Token = "0x401B8FF")]
			[FieldOffset(Offset = "0x38")]
			public UISpineHolder.SpineAnimParam animParam;
		}
	}
}
