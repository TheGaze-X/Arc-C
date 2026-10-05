using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DB1 RID: 28081
	[Token(Token = "0x2006DB1")]
	public class ActivityCommonCheckinV2ItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FD9 RID: 163801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD9")]
		[Address(RVA = "0x2338F70", Offset = "0x2337B70", VA = "0x182338F70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027FDA RID: 163802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FDA")]
		[Address(RVA = "0x2338D40", Offset = "0x2337940", VA = "0x182338D40")]
		public void Render(ActivityCommonCheckinV2ItemObj.CheckinCardSubObjViewModel viewModel)
		{
		}

		// Token: 0x06027FDB RID: 163803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FDB")]
		[Address(RVA = "0x2339130", Offset = "0x2337D30", VA = "0x182339130")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06027FDC RID: 163804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FDC")]
		[Address(RVA = "0x2339220", Offset = "0x2337E20", VA = "0x182339220")]
		public ActivityCommonCheckinV2ItemObj()
		{
		}

		// Token: 0x04038B09 RID: 232201
		[Token(Token = "0x4038B09")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04038B0A RID: 232202
		[Token(Token = "0x4038B0A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x04038B0B RID: 232203
		[Token(Token = "0x4038B0B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04038B0C RID: 232204
		[Token(Token = "0x4038B0C")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x04038B0D RID: 232205
		[Token(Token = "0x4038B0D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04038B0E RID: 232206
		[Token(Token = "0x4038B0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038B0F RID: 232207
		[Token(Token = "0x4038B0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038B10 RID: 232208
		[Token(Token = "0x4038B10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04038B11 RID: 232209
		[Token(Token = "0x4038B11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DB2 RID: 28082
		[Token(Token = "0x2006DB2")]
		public struct CheckinCardSubObjViewModel
		{
			// Token: 0x04038B12 RID: 232210
			[Token(Token = "0x4038B12")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04038B13 RID: 232211
			[Token(Token = "0x4038B13")]
			[FieldOffset(Offset = "0x8")]
			public UIItemViewModel itemViewModel;

			// Token: 0x04038B14 RID: 232212
			[Token(Token = "0x4038B14")]
			[FieldOffset(Offset = "0x10")]
			public float scale;

			// Token: 0x04038B15 RID: 232213
			[Token(Token = "0x4038B15")]
			[FieldOffset(Offset = "0x14")]
			public int preferredHeight;

			// Token: 0x04038B16 RID: 232214
			[Token(Token = "0x4038B16")]
			[FieldOffset(Offset = "0x18")]
			public bool isClickable;
		}
	}
}
