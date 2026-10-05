using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004992 RID: 18834
	[Token(Token = "0x2004992")]
	public class MedalBarListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C613 RID: 116243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C613")]
		[Address(RVA = "0x15E6DE0", Offset = "0x15E59E0", VA = "0x1815E6DE0")]
		public void Render(MedalTypeViewModel viewModel)
		{
		}

		// Token: 0x0601C614 RID: 116244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C614")]
		[Address(RVA = "0x15E6CD0", Offset = "0x15E58D0", VA = "0x1815E6CD0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C615 RID: 116245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C615")]
		[Address(RVA = "0x15E7190", Offset = "0x15E5D90", VA = "0x1815E7190")]
		public void SetCount(int delta, float minHeight, float maxHeight)
		{
		}

		// Token: 0x0601C616 RID: 116246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C616")]
		[Address(RVA = "0x15E70E0", Offset = "0x15E5CE0", VA = "0x1815E70E0")]
		public void ResetProgressAnim()
		{
		}

		// Token: 0x0601C617 RID: 116247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C617")]
		[Address(RVA = "0x15E7520", Offset = "0x15E6120", VA = "0x1815E7520")]
		public void SwitchProgressDisplay(bool showDetails)
		{
		}

		// Token: 0x0601C618 RID: 116248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C618")]
		[Address(RVA = "0x15E7470", Offset = "0x15E6070", VA = "0x1815E7470")]
		public void StopProgressAnim()
		{
		}

		// Token: 0x0601C619 RID: 116249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C619")]
		[Address(RVA = "0x15E76F0", Offset = "0x15E62F0", VA = "0x1815E76F0")]
		public MedalBarListItem()
		{
		}

		// Token: 0x040252A3 RID: 152227
		[Token(Token = "0x40252A3")]
		[FieldOffset(Offset = "0x0")]
		private static string LIST_ITEM_ANIM;

		// Token: 0x040252A4 RID: 152228
		[Token(Token = "0x40252A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x040252A5 RID: 152229
		[Token(Token = "0x40252A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _medalName;

		// Token: 0x040252A6 RID: 152230
		[Token(Token = "0x40252A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _medalName2;

		// Token: 0x040252A7 RID: 152231
		[Token(Token = "0x40252A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _countText;

		// Token: 0x040252A8 RID: 152232
		[Token(Token = "0x40252A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rect;

		// Token: 0x040252A9 RID: 152233
		[Token(Token = "0x40252A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _showCountBan;

		// Token: 0x040252AA RID: 152234
		[Token(Token = "0x40252AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x040252AB RID: 152235
		[Token(Token = "0x40252AB")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x040252AC RID: 152236
		[Token(Token = "0x40252AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LayoutElement _layoutSize;

		// Token: 0x040252AD RID: 152237
		[Token(Token = "0x40252AD")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public bool showCountFlag;

		// Token: 0x040252AE RID: 152238
		[Token(Token = "0x40252AE")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_currentTween;

		// Token: 0x040252AF RID: 152239
		[Token(Token = "0x40252AF")]
		[FieldOffset(Offset = "0x70")]
		private MedalTypeViewModel m_cacheViewModel;

		// Token: 0x040252B0 RID: 152240
		[Token(Token = "0x40252B0")]
		[FieldOffset(Offset = "0x78")]
		private MedalBarListItem.RenderCache m_renderCache;

		// Token: 0x040252B1 RID: 152241
		[Token(Token = "0x40252B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252B2 RID: 152242
		[Token(Token = "0x40252B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040252B3 RID: 152243
		[Token(Token = "0x40252B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCount;

		// Token: 0x040252B4 RID: 152244
		[Token(Token = "0x40252B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetProgressAnim;

		// Token: 0x040252B5 RID: 152245
		[Token(Token = "0x40252B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchProgressDisplay;

		// Token: 0x040252B6 RID: 152246
		[Token(Token = "0x40252B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopProgressAnim;

		// Token: 0x040252B7 RID: 152247
		[Token(Token = "0x40252B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004993 RID: 18835
		[Token(Token = "0x2004993")]
		private struct RenderCache
		{
			// Token: 0x0601C61D RID: 116253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C61D")]
			[Address(RVA = "0x15F05E0", Offset = "0x15EF1E0", VA = "0x1815F05E0")]
			public RenderCache(int posDelta, float minHeight, float maxHeight)
			{
			}

			// Token: 0x040252B8 RID: 152248
			[Token(Token = "0x40252B8")]
			[FieldOffset(Offset = "0x0")]
			public int posDelta;

			// Token: 0x040252B9 RID: 152249
			[Token(Token = "0x40252B9")]
			[FieldOffset(Offset = "0x4")]
			public int minHeight;

			// Token: 0x040252BA RID: 152250
			[Token(Token = "0x40252BA")]
			[FieldOffset(Offset = "0x8")]
			public int maxHeight;
		}
	}
}
