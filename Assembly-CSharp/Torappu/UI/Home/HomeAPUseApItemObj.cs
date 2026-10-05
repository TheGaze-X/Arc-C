using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BD5 RID: 19413
	[Token(Token = "0x2004BD5")]
	public class HomeAPUseApItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x170044A5 RID: 17573
		// (set) Token: 0x0601D2DC RID: 119516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044A5")]
		public Action<int> refreshTime
		{
			[Token(Token = "0x601D2DC")]
			[Address(RVA = "0x16BAA20", Offset = "0x16B9620", VA = "0x1816BAA20")]
			set
			{
			}
		}

		// Token: 0x0601D2DD RID: 119517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2DD")]
		[Address(RVA = "0x16BA7D0", Offset = "0x16B93D0", VA = "0x1816BA7D0")]
		private void _InitItemIfNot()
		{
		}

		// Token: 0x0601D2DE RID: 119518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2DE")]
		[Address(RVA = "0x16BA4A0", Offset = "0x16B90A0", VA = "0x1816BA4A0")]
		public void CleanEvent()
		{
		}

		// Token: 0x0601D2DF RID: 119519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2DF")]
		[Address(RVA = "0x16BA530", Offset = "0x16B9130", VA = "0x1816BA530")]
		public void RenderItem(UIItemViewModel itemInfo, int count, Action<int> clickEvent, Action<int> cleanEvent, Func<int, bool> OnLongClick, int position)
		{
		}

		// Token: 0x0601D2E0 RID: 119520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E0")]
		[Address(RVA = "0x16BA9A0", Offset = "0x16B95A0", VA = "0x1816BA9A0")]
		public HomeAPUseApItemObj()
		{
		}

		// Token: 0x040264AD RID: 156845
		[Token(Token = "0x40264AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040264AE RID: 156846
		[Token(Token = "0x40264AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _chosenCount;

		// Token: 0x040264AF RID: 156847
		[Token(Token = "0x40264AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x040264B0 RID: 156848
		[Token(Token = "0x40264B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _minusObj;

		// Token: 0x040264B1 RID: 156849
		[Token(Token = "0x40264B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _backSelectObj;

		// Token: 0x040264B2 RID: 156850
		[Token(Token = "0x40264B2")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> cleanEvent;

		// Token: 0x040264B3 RID: 156851
		[Token(Token = "0x40264B3")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x040264B4 RID: 156852
		[Token(Token = "0x40264B4")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_itemCard;

		// Token: 0x040264B5 RID: 156853
		[Token(Token = "0x40264B5")]
		[FieldOffset(Offset = "0x58")]
		private int m_pos;

		// Token: 0x040264B6 RID: 156854
		[Token(Token = "0x40264B6")]
		[FieldOffset(Offset = "0x0")]
		private static Color ADDITIVE_COLOR;

		// Token: 0x040264B7 RID: 156855
		[Token(Token = "0x40264B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_refreshTime;

		// Token: 0x040264B8 RID: 156856
		[Token(Token = "0x40264B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitItemIfNot;

		// Token: 0x040264B9 RID: 156857
		[Token(Token = "0x40264B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CleanEvent;

		// Token: 0x040264BA RID: 156858
		[Token(Token = "0x40264BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x040264BB RID: 156859
		[Token(Token = "0x40264BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
