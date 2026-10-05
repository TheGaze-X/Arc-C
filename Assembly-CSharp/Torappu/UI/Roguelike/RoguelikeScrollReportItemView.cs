using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053BD RID: 21437
	[Token(Token = "0x20053BD")]
	public class RoguelikeScrollReportItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F8C7 RID: 129223 RVA: 0x000B22F0 File Offset: 0x000B04F0
		[Token(Token = "0x601F8C7")]
		[Address(RVA = "0x1947530", Offset = "0x1946130", VA = "0x181947530")]
		public float PrefabOnlyCalcHeight(string content)
		{
			return 0f;
		}

		// Token: 0x0601F8C8 RID: 129224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8C8")]
		[Address(RVA = "0x1947730", Offset = "0x1946330", VA = "0x181947730")]
		public RoguelikeScrollReportItemView()
		{
		}

		// Token: 0x0402A786 RID: 173958
		[Token(Token = "0x402A786")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402A787 RID: 173959
		[Token(Token = "0x402A787")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _icon;

		// Token: 0x0402A788 RID: 173960
		[Token(Token = "0x402A788")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _paddings;

		// Token: 0x0402A789 RID: 173961
		[Token(Token = "0x402A789")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0402A78A RID: 173962
		[Token(Token = "0x402A78A")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402A78B RID: 173963
		[Token(Token = "0x402A78B")]
		[FieldOffset(Offset = "0x38")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402A78C RID: 173964
		[Token(Token = "0x402A78C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrefabOnlyCalcHeight;

		// Token: 0x0402A78D RID: 173965
		[Token(Token = "0x402A78D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053BE RID: 21438
		[Token(Token = "0x20053BE")]
		public class VirtualView : BasicReportItem<RoguelikeScrollReportItemView>
		{
			// Token: 0x0601F8C9 RID: 129225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8C9")]
			[Address(RVA = "0x194E800", Offset = "0x194D400", VA = "0x18194E800")]
			public void SetParams(string text, SpriteRenderData icon)
			{
			}

			// Token: 0x0601F8CA RID: 129226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8CA")]
			[Address(RVA = "0x194E790", Offset = "0x194D390", VA = "0x18194E790")]
			public void OverrideHeight(float height)
			{
			}

			// Token: 0x0601F8CB RID: 129227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8CB")]
			[Address(RVA = "0x194E980", Offset = "0x194D580", VA = "0x18194E980")]
			public VirtualView(RoguelikeScrollReportItemView prefab)
			{
			}

			// Token: 0x0601F8CC RID: 129228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F8CC")]
			[Address(RVA = "0x194E020", Offset = "0x194CC20", VA = "0x18194E020", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601F8CD RID: 129229 RVA: 0x000B2308 File Offset: 0x000B0508
			[Token(Token = "0x601F8CD")]
			[Address(RVA = "0x194E090", Offset = "0x194CC90", VA = "0x18194E090", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601F8CE RID: 129230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F8CE")]
			[Address(RVA = "0x194E4B0", Offset = "0x194D0B0", VA = "0x18194E4B0", Slot = "14")]
			protected override void OnRenderView(RoguelikeScrollReportItemView view)
			{
			}

			// Token: 0x0402A78E RID: 173966
			[Token(Token = "0x402A78E")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeScrollReportItemView m_prefab;

			// Token: 0x0402A78F RID: 173967
			[Token(Token = "0x402A78F")]
			[FieldOffset(Offset = "0x28")]
			private float m_cachedHeight;

			// Token: 0x0402A790 RID: 173968
			[Token(Token = "0x402A790")]
			[FieldOffset(Offset = "0x30")]
			private string m_text;

			// Token: 0x0402A791 RID: 173969
			[Token(Token = "0x402A791")]
			[FieldOffset(Offset = "0x38")]
			private SpriteRenderData m_icon;

			// Token: 0x0402A792 RID: 173970
			[Token(Token = "0x402A792")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetParams;

			// Token: 0x0402A793 RID: 173971
			[Token(Token = "0x402A793")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideHeight;

			// Token: 0x0402A794 RID: 173972
			[Token(Token = "0x402A794")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A795 RID: 173973
			[Token(Token = "0x402A795")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402A796 RID: 173974
			[Token(Token = "0x402A796")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402A797 RID: 173975
			[Token(Token = "0x402A797")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
