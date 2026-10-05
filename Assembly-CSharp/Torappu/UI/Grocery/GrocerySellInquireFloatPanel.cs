using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF5 RID: 19701
	[Token(Token = "0x2004CF5")]
	public class GrocerySellInquireFloatPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x0601D870 RID: 120944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700455D")]
		public UIFadeFloatPanel fadeFloatPanel
		{
			[Token(Token = "0x601D870")]
			[Address(RVA = "0x1717200", Offset = "0x1715E00", VA = "0x181717200")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D871 RID: 120945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D871")]
		[Address(RVA = "0x1716CB0", Offset = "0x17158B0", VA = "0x181716CB0")]
		public void Render(string actId)
		{
		}

		// Token: 0x0601D872 RID: 120946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D872")]
		[Address(RVA = "0x1716C40", Offset = "0x1715840", VA = "0x181716C40")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601D873 RID: 120947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D873")]
		[Address(RVA = "0x1716FE0", Offset = "0x1715BE0", VA = "0x181716FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D874 RID: 120948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D874")]
		[Address(RVA = "0x17171A0", Offset = "0x1715DA0", VA = "0x1817171A0")]
		public GrocerySellInquireFloatPanel()
		{
		}

		// Token: 0x04026F41 RID: 159553
		[Token(Token = "0x4026F41")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadeFloatPanel;

		// Token: 0x04026F42 RID: 159554
		[Token(Token = "0x4026F42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04026F43 RID: 159555
		[Token(Token = "0x4026F43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04026F44 RID: 159556
		[Token(Token = "0x4026F44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04026F45 RID: 159557
		[Token(Token = "0x4026F45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectBackBtn;

		// Token: 0x04026F46 RID: 159558
		[Token(Token = "0x4026F46")]
		[FieldOffset(Offset = "0x40")]
		private GrocerySellInquireFloatPanel.Adapter m_adapter;

		// Token: 0x04026F47 RID: 159559
		[Token(Token = "0x4026F47")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04026F48 RID: 159560
		[Token(Token = "0x4026F48")]
		[FieldOffset(Offset = "0x50")]
		private List<Act27SideData.Act27SideInquireData> m_cachedInquireList;

		// Token: 0x04026F49 RID: 159561
		[Token(Token = "0x4026F49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeFloatPanel;

		// Token: 0x04026F4A RID: 159562
		[Token(Token = "0x4026F4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026F4B RID: 159563
		[Token(Token = "0x4026F4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04026F4C RID: 159564
		[Token(Token = "0x4026F4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026F4D RID: 159565
		[Token(Token = "0x4026F4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CF6 RID: 19702
		[Token(Token = "0x2004CF6")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D875 RID: 120949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D875")]
			[Address(RVA = "0x170DA10", Offset = "0x170C610", VA = "0x18170DA10")]
			public Adapter(GrocerySellInquireFloatPanel closure)
			{
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0601D876 RID: 120950 RVA: 0x000ABD98 File Offset: 0x000A9F98
			[Token(Token = "0x1700455E")]
			public override int count
			{
				[Token(Token = "0x601D876")]
				[Address(RVA = "0x170DA90", Offset = "0x170C690", VA = "0x18170DA90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D877 RID: 120951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D877")]
			[Address(RVA = "0x170D6C0", Offset = "0x170C2C0", VA = "0x18170D6C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026F4E RID: 159566
			[Token(Token = "0x4026F4E")]
			[FieldOffset(Offset = "0x20")]
			private GrocerySellInquireFloatPanel m_closure;

			// Token: 0x04026F4F RID: 159567
			[Token(Token = "0x4026F4F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026F50 RID: 159568
			[Token(Token = "0x4026F50")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026F51 RID: 159569
			[Token(Token = "0x4026F51")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
