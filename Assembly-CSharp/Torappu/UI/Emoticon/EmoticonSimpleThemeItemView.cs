using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050E6 RID: 20710
	[Token(Token = "0x20050E6")]
	public class EmoticonSimpleThemeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E9E2 RID: 125410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9E2")]
		[Address(RVA = "0x1861D70", Offset = "0x1860970", VA = "0x181861D70")]
		public void Render(EmoticonThemeItemModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601E9E3 RID: 125411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9E3")]
		[Address(RVA = "0x1861F60", Offset = "0x1860B60", VA = "0x181861F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E9E4 RID: 125412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9E4")]
		[Address(RVA = "0x1862080", Offset = "0x1860C80", VA = "0x181862080")]
		public EmoticonSimpleThemeItemView()
		{
		}

		// Token: 0x04029096 RID: 168086
		[Token(Token = "0x4029096")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _emojiItemContent;

		// Token: 0x04029097 RID: 168087
		[Token(Token = "0x4029097")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _displayEmptySlot;

		// Token: 0x04029098 RID: 168088
		[Token(Token = "0x4029098")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxSlotCount;

		// Token: 0x04029099 RID: 168089
		[Token(Token = "0x4029099")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0402909A RID: 168090
		[Token(Token = "0x402909A")]
		[FieldOffset(Offset = "0x30")]
		private EmoticonThemeItemModel m_cachedModel;

		// Token: 0x0402909B RID: 168091
		[Token(Token = "0x402909B")]
		[FieldOffset(Offset = "0x38")]
		private EmoticonSimpleThemeItemView.EmojiItemAdapter m_emojiItemAdapter;

		// Token: 0x0402909C RID: 168092
		[Token(Token = "0x402909C")]
		[FieldOffset(Offset = "0x40")]
		private ILoadAsset m_cachedAssetLoader;

		// Token: 0x0402909D RID: 168093
		[Token(Token = "0x402909D")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string, string> onClickEmojiItem;

		// Token: 0x0402909E RID: 168094
		[Token(Token = "0x402909E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402909F RID: 168095
		[Token(Token = "0x402909F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040290A0 RID: 168096
		[Token(Token = "0x40290A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020050E7 RID: 20711
		[Token(Token = "0x20050E7")]
		private class EmojiItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E9E5 RID: 125413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E9E5")]
			[Address(RVA = "0x1861330", Offset = "0x185FF30", VA = "0x181861330")]
			public EmojiItemAdapter(EmoticonSimpleThemeItemView closure)
			{
			}

			// Token: 0x1700476C RID: 18284
			// (get) Token: 0x0601E9E6 RID: 125414 RVA: 0x000AF158 File Offset: 0x000AD358
			[Token(Token = "0x1700476C")]
			public override int count
			{
				[Token(Token = "0x601E9E6")]
				[Address(RVA = "0x18613B0", Offset = "0x185FFB0", VA = "0x1818613B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E9E7 RID: 125415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E9E7")]
			[Address(RVA = "0x1861110", Offset = "0x185FD10", VA = "0x181861110", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040290A1 RID: 168097
			[Token(Token = "0x40290A1")]
			[FieldOffset(Offset = "0x20")]
			private EmoticonSimpleThemeItemView m_closure;

			// Token: 0x040290A2 RID: 168098
			[Token(Token = "0x40290A2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040290A3 RID: 168099
			[Token(Token = "0x40290A3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040290A4 RID: 168100
			[Token(Token = "0x40290A4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
