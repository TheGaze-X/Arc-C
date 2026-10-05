using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF8 RID: 15608
	[Token(Token = "0x2003CF8")]
	public class TuningProductBagState : PopupFadeState
	{
		// Token: 0x06018562 RID: 99682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018562")]
		[Address(RVA = "0x10DC4B0", Offset = "0x10DB0B0", VA = "0x1810DC4B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018563 RID: 99683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018563")]
		[Address(RVA = "0x10DC510", Offset = "0x10DB110", VA = "0x1810DC510", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018564 RID: 99684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018564")]
		[Address(RVA = "0x10DC810", Offset = "0x10DB410", VA = "0x1810DC810", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018565 RID: 99685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018565")]
		[Address(RVA = "0x10DC970", Offset = "0x10DB570", VA = "0x1810DC970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018566 RID: 99686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018566")]
		[Address(RVA = "0x10DCBC0", Offset = "0x10DB7C0", VA = "0x1810DCBC0")]
		private void _OnSelectProductType(string productTypeId)
		{
		}

		// Token: 0x06018567 RID: 99687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018567")]
		[Address(RVA = "0x10DCCF0", Offset = "0x10DB8F0", VA = "0x1810DCCF0")]
		private void _TransToProductState(IStateBean stateBean)
		{
		}

		// Token: 0x06018568 RID: 99688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018568")]
		[Address(RVA = "0x10DCB20", Offset = "0x10DB720", VA = "0x1810DCB20")]
		private void _OnBackPress()
		{
		}

		// Token: 0x06018569 RID: 99689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018569")]
		[Address(RVA = "0x10DCE10", Offset = "0x10DBA10", VA = "0x1810DCE10")]
		public TuningProductBagState()
		{
		}

		// Token: 0x0601856A RID: 99690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601856A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601856B RID: 99691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601856B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401DBE6 RID: 121830
		[Token(Token = "0x401DBE6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningProductBagView _bagView;

		// Token: 0x0401DBE7 RID: 121831
		[Token(Token = "0x401DBE7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0401DBE8 RID: 121832
		[Token(Token = "0x401DBE8")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401DBE9 RID: 121833
		[Token(Token = "0x401DBE9")]
		[FieldOffset(Offset = "0x88")]
		private TuningProductBagStateBean m_stateBean;

		// Token: 0x0401DBEA RID: 121834
		[Token(Token = "0x401DBEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DBEB RID: 121835
		[Token(Token = "0x401DBEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DBEC RID: 121836
		[Token(Token = "0x401DBEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401DBED RID: 121837
		[Token(Token = "0x401DBED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DBEE RID: 121838
		[Token(Token = "0x401DBEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectProductType;

		// Token: 0x0401DBEF RID: 121839
		[Token(Token = "0x401DBEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TransToProductState;

		// Token: 0x0401DBF0 RID: 121840
		[Token(Token = "0x401DBF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x0401DBF1 RID: 121841
		[Token(Token = "0x401DBF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
