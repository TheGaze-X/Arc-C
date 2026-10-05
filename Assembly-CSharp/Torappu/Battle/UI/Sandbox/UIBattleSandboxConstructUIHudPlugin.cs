using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033BF RID: 13247
	[Token(Token = "0x20033BF")]
	public class UIBattleSandboxConstructUIHudPlugin : UnitHudPluginManager.HudPlugin, ConstructLandPageBinder.IConstructSceneView
	{
		// Token: 0x06015236 RID: 86582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015236")]
		[Address(RVA = "0xD8B450", Offset = "0xD8A050", VA = "0x180D8B450", Slot = "9")]
		protected override void DoAttach(Unit owner)
		{
		}

		// Token: 0x06015237 RID: 86583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015237")]
		[Address(RVA = "0xD8BB40", Offset = "0xD8A740", VA = "0x180D8BB40")]
		private void Update()
		{
		}

		// Token: 0x06015238 RID: 86584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015238")]
		[Address(RVA = "0xD8B770", Offset = "0xD8A370", VA = "0x180D8B770", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06015239 RID: 86585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015239")]
		[Address(RVA = "0xD8B7F0", Offset = "0xD8A3F0", VA = "0x180D8B7F0", Slot = "11")]
		public void OnValueChanged(ConstructLandPageProp property)
		{
		}

		// Token: 0x0601523A RID: 86586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601523A")]
		[Address(RVA = "0xD8BC20", Offset = "0xD8A820", VA = "0x180D8BC20")]
		public UIBattleSandboxConstructUIHudPlugin()
		{
		}

		// Token: 0x0601523B RID: 86587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601523B")]
		[Address(RVA = "0xCCDF70", Offset = "0xCCCB70", VA = "0x180CCDF70")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0)
		{
		}

		// Token: 0x0601523C RID: 86588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601523C")]
		[Address(RVA = "0xCCDF80", Offset = "0xCCCB80", VA = "0x180CCDF80")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04019348 RID: 103240
		[Token(Token = "0x4019348")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _iconLayout;

		// Token: 0x04019349 RID: 103241
		[Token(Token = "0x4019349")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<UIBattleSandboxConstructUIHudPlugin.IconTipPair> _iconPair;

		// Token: 0x0401934A RID: 103242
		[Token(Token = "0x401934A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _defaultSprite;

		// Token: 0x0401934B RID: 103243
		[Token(Token = "0x401934B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_binded;

		// Token: 0x0401934C RID: 103244
		[Token(Token = "0x401934C")]
		[FieldOffset(Offset = "0x48")]
		private UIBattleSandboxConstructUIHudPlugin.Adapter m_adapter;

		// Token: 0x0401934D RID: 103245
		[Token(Token = "0x401934D")]
		[FieldOffset(Offset = "0x50")]
		private Character m_characterOwner;

		// Token: 0x0401934E RID: 103246
		[Token(Token = "0x401934E")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<string, int> m_upgradeCache;

		// Token: 0x0401934F RID: 103247
		[Token(Token = "0x401934F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04019350 RID: 103248
		[Token(Token = "0x4019350")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019351 RID: 103249
		[Token(Token = "0x4019351")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04019352 RID: 103250
		[Token(Token = "0x4019352")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04019353 RID: 103251
		[Token(Token = "0x4019353")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033C0 RID: 13248
		[Token(Token = "0x20033C0")]
		[Serializable]
		private struct IconTipPair
		{
			// Token: 0x04019354 RID: 103252
			[Token(Token = "0x4019354")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2ConstructTipType tip;

			// Token: 0x04019355 RID: 103253
			[Token(Token = "0x4019355")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}

		// Token: 0x020033C1 RID: 13249
		[Token(Token = "0x20033C1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601523D RID: 86589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601523D")]
			[Address(RVA = "0xD81B90", Offset = "0xD80790", VA = "0x180D81B90")]
			public Adapter(List<UIBattleSandboxConstructUIHudPlugin.IconTipPair> iconTipPairs, Sprite defaultSprite)
			{
			}

			// Token: 0x1700322B RID: 12843
			// (get) Token: 0x0601523E RID: 86590 RVA: 0x0008A858 File Offset: 0x00088A58
			[Token(Token = "0x1700322B")]
			public override int count
			{
				[Token(Token = "0x601523E")]
				[Address(RVA = "0xD81C90", Offset = "0xD80890", VA = "0x180D81C90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601523F RID: 86591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601523F")]
			[Address(RVA = "0xD818E0", Offset = "0xD804E0", VA = "0x180D818E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04019356 RID: 103254
			[Token(Token = "0x4019356")]
			[FieldOffset(Offset = "0x20")]
			public List<SandboxV2ConstructTipType> tips;

			// Token: 0x04019357 RID: 103255
			[Token(Token = "0x4019357")]
			[FieldOffset(Offset = "0x28")]
			public List<UIBattleSandboxConstructUIHudPlugin.IconTipPair> iconPair;

			// Token: 0x04019358 RID: 103256
			[Token(Token = "0x4019358")]
			[FieldOffset(Offset = "0x30")]
			public Sprite defaultSprite;

			// Token: 0x04019359 RID: 103257
			[Token(Token = "0x4019359")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401935A RID: 103258
			[Token(Token = "0x401935A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401935B RID: 103259
			[Token(Token = "0x401935B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
