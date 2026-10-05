using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA7 RID: 31399
	[Token(Token = "0x2007AA7")]
	public class Act12sideEntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x0602BFC6 RID: 180166 RVA: 0x000DDDA8 File Offset: 0x000DBFA8
		[Token(Token = "0x1700671A")]
		public Act12SideData.ActZoneClass zoneClass
		{
			[Token(Token = "0x602BFC6")]
			[Address(RVA = "0x27DA490", Offset = "0x27D9090", VA = "0x1827DA490")]
			get
			{
				return Act12SideData.ActZoneClass.NONE;
			}
		}

		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x0602BFC7 RID: 180167 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFC8 RID: 180168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700671B")]
		public Action<string> onZoneClick
		{
			[Token(Token = "0x602BFC7")]
			[Address(RVA = "0x27DA430", Offset = "0x27D9030", VA = "0x1827DA430")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFC8")]
			[Address(RVA = "0x27DA4F0", Offset = "0x27D90F0", VA = "0x1827DA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BFC9 RID: 180169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFC9")]
		[Address(RVA = "0x27D9AB0", Offset = "0x27D86B0", VA = "0x1827D9AB0")]
		public void Render(Act12sideZoneDescViewModel viewModel)
		{
		}

		// Token: 0x0602BFCA RID: 180170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCA")]
		[Address(RVA = "0x27DA2A0", Offset = "0x27D8EA0", VA = "0x1827DA2A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BFCB RID: 180171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCB")]
		[Address(RVA = "0x27D9930", Offset = "0x27D8530", VA = "0x1827D9930")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602BFCC RID: 180172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFCC")]
		[Address(RVA = "0x27DA3D0", Offset = "0x27D8FD0", VA = "0x1827DA3D0")]
		public Act12sideEntryZoneView()
		{
		}

		// Token: 0x0403FB68 RID: 260968
		[Token(Token = "0x403FB68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12SideData.ActZoneClass _zoneClass;

		// Token: 0x0403FB69 RID: 260969
		[Token(Token = "0x403FB69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _btnZone;

		// Token: 0x0403FB6A RID: 260970
		[Token(Token = "0x403FB6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _goNewSign;

		// Token: 0x0403FB6B RID: 260971
		[Token(Token = "0x403FB6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x0403FB6C RID: 260972
		[Token(Token = "0x403FB6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0403FB6D RID: 260973
		[Token(Token = "0x403FB6D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403FB6E RID: 260974
		[Token(Token = "0x403FB6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403FB6F RID: 260975
		[Token(Token = "0x403FB6F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _timeoutPartGo;

		// Token: 0x0403FB70 RID: 260976
		[Token(Token = "0x403FB70")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _animObjs;

		// Token: 0x0403FB71 RID: 260977
		[Token(Token = "0x403FB71")]
		[FieldOffset(Offset = "0x60")]
		private Act12sideZoneDescViewModel m_viewModel;

		// Token: 0x0403FB72 RID: 260978
		[Token(Token = "0x403FB72")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403FB73 RID: 260979
		[Token(Token = "0x403FB73")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_trackPoint;

		// Token: 0x0403FB75 RID: 260981
		[Token(Token = "0x403FB75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneClass;

		// Token: 0x0403FB76 RID: 260982
		[Token(Token = "0x403FB76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onZoneClick;

		// Token: 0x0403FB77 RID: 260983
		[Token(Token = "0x403FB77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onZoneClick;

		// Token: 0x0403FB78 RID: 260984
		[Token(Token = "0x403FB78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FB79 RID: 260985
		[Token(Token = "0x403FB79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FB7A RID: 260986
		[Token(Token = "0x403FB7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403FB7B RID: 260987
		[Token(Token = "0x403FB7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
