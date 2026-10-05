using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AAB RID: 31403
	[Token(Token = "0x2007AAB")]
	public class Act12sideMapZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x0602BFD9 RID: 180185 RVA: 0x000DDDD8 File Offset: 0x000DBFD8
		[Token(Token = "0x1700671C")]
		public Act12SideData.ActZoneClass zoneClass
		{
			[Token(Token = "0x602BFD9")]
			[Address(RVA = "0x27DBBE0", Offset = "0x27DA7E0", VA = "0x1827DBBE0")]
			get
			{
				return Act12SideData.ActZoneClass.NONE;
			}
		}

		// Token: 0x0602BFDA RID: 180186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFDA")]
		[Address(RVA = "0x27DB7A0", Offset = "0x27DA3A0", VA = "0x1827DB7A0")]
		public void Render(Act12sideZoneDescViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0602BFDB RID: 180187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFDB")]
		[Address(RVA = "0x27DBA20", Offset = "0x27DA620", VA = "0x1827DBA20", Slot = "4")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x0602BFDC RID: 180188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFDC")]
		[Address(RVA = "0x27DB710", Offset = "0x27DA310", VA = "0x1827DB710")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602BFDD RID: 180189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFDD")]
		[Address(RVA = "0x27DBB50", Offset = "0x27DA750", VA = "0x1827DBB50")]
		public Act12sideMapZoneView()
		{
		}

		// Token: 0x0403FB94 RID: 261012
		[Token(Token = "0x403FB94")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12SideData.ActZoneClass _zoneClass;

		// Token: 0x0403FB95 RID: 261013
		[Token(Token = "0x403FB95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objIcon;

		// Token: 0x0403FB96 RID: 261014
		[Token(Token = "0x403FB96")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objSelected;

		// Token: 0x0403FB97 RID: 261015
		[Token(Token = "0x403FB97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objLocked;

		// Token: 0x0403FB98 RID: 261016
		[Token(Token = "0x403FB98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _normalWidth;

		// Token: 0x0403FB99 RID: 261017
		[Token(Token = "0x403FB99")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _selectedWidth;

		// Token: 0x0403FB9A RID: 261018
		[Token(Token = "0x403FB9A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _lockWidth;

		// Token: 0x0403FB9B RID: 261019
		[Token(Token = "0x403FB9B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutElement _zoneLayout;

		// Token: 0x0403FB9C RID: 261020
		[Token(Token = "0x403FB9C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403FB9D RID: 261021
		[Token(Token = "0x403FB9D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected GameObject _objNew;

		// Token: 0x0403FB9E RID: 261022
		[Token(Token = "0x403FB9E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x0403FB9F RID: 261023
		[Token(Token = "0x403FB9F")]
		[FieldOffset(Offset = "0x68")]
		private string m_zoneId;

		// Token: 0x0403FBA0 RID: 261024
		[Token(Token = "0x403FBA0")]
		[FieldOffset(Offset = "0x70")]
		protected bool m_hasInited;

		// Token: 0x0403FBA1 RID: 261025
		[Token(Token = "0x403FBA1")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_trackPoint;

		// Token: 0x0403FBA2 RID: 261026
		[Token(Token = "0x403FBA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneClass;

		// Token: 0x0403FBA3 RID: 261027
		[Token(Token = "0x403FBA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FBA4 RID: 261028
		[Token(Token = "0x403FBA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FBA5 RID: 261029
		[Token(Token = "0x403FBA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403FBA6 RID: 261030
		[Token(Token = "0x403FBA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
