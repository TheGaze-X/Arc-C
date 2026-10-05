using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200404A RID: 16458
	[Token(Token = "0x200404A")]
	public class SandboxV2AdminCharSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06019757 RID: 104279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019757")]
		[Address(RVA = "0x122C8A0", Offset = "0x122B4A0", VA = "0x18122C8A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019758 RID: 104280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019758")]
		[Address(RVA = "0x122D760", Offset = "0x122C360", VA = "0x18122D760", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019759 RID: 104281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019759")]
		[Address(RVA = "0x122C900", Offset = "0x122B500", VA = "0x18122C900", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601975A RID: 104282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975A")]
		[Address(RVA = "0x122D6D0", Offset = "0x122C2D0", VA = "0x18122D6D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601975B RID: 104283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975B")]
		[Address(RVA = "0x122D4A0", Offset = "0x122C0A0", VA = "0x18122D4A0")]
		public void OnOpenCharDetail()
		{
		}

		// Token: 0x0601975C RID: 104284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975C")]
		[Address(RVA = "0x122D640", Offset = "0x122C240", VA = "0x18122D640")]
		public void OnOpenEatFood()
		{
		}

		// Token: 0x0601975D RID: 104285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975D")]
		[Address(RVA = "0x122CB80", Offset = "0x122B780", VA = "0x18122CB80", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601975E RID: 104286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975E")]
		[Address(RVA = "0x122DB00", Offset = "0x122C700", VA = "0x18122DB00")]
		private void _OnEnsure()
		{
		}

		// Token: 0x0601975F RID: 104287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601975F")]
		[Address(RVA = "0x122DA40", Offset = "0x122C640", VA = "0x18122DA40")]
		private void _DismissWithEnsure()
		{
		}

		// Token: 0x06019760 RID: 104288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019760")]
		[Address(RVA = "0x122DD10", Offset = "0x122C910", VA = "0x18122DD10")]
		private void _OnProduceDrink()
		{
		}

		// Token: 0x06019761 RID: 104289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019761")]
		[Address(RVA = "0x122DFA0", Offset = "0x122CBA0", VA = "0x18122DFA0")]
		private void _OnSwitchPopView(bool isShow)
		{
		}

		// Token: 0x06019762 RID: 104290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019762")]
		[Address(RVA = "0x122E0A0", Offset = "0x122CCA0", VA = "0x18122E0A0")]
		public SandboxV2AdminCharSelectState()
		{
		}

		// Token: 0x06019764 RID: 104292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019764")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019765 RID: 104293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019765")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019766 RID: 104294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019766")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401FB4F RID: 129871
		[Token(Token = "0x401FB4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminSelectListView _listView;

		// Token: 0x0401FB50 RID: 129872
		[Token(Token = "0x401FB50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x0401FB51 RID: 129873
		[Token(Token = "0x401FB51")]
		[NonSerialized]
		public const int ATTR_SELECT_TAB_CLICKED = 1;

		// Token: 0x0401FB52 RID: 129874
		[Token(Token = "0x401FB52")]
		[NonSerialized]
		public const int ON_CHAR_SELECT_CLICKED = 2;

		// Token: 0x0401FB53 RID: 129875
		[Token(Token = "0x401FB53")]
		[NonSerialized]
		public const int ON_CHANGE_SKILL = 3;

		// Token: 0x0401FB54 RID: 129876
		[Token(Token = "0x401FB54")]
		[NonSerialized]
		public const int ON_CHANGE_EQUIP = 4;

		// Token: 0x0401FB55 RID: 129877
		[Token(Token = "0x401FB55")]
		[NonSerialized]
		public const int ON_SHUFFLE_PROF_OPEN = 5;

		// Token: 0x0401FB56 RID: 129878
		[Token(Token = "0x401FB56")]
		[NonSerialized]
		public const int ON_CLOSE_SHUFFLE_PROF = 6;

		// Token: 0x0401FB57 RID: 129879
		[Token(Token = "0x401FB57")]
		[NonSerialized]
		public const int ON_SHUFFLE_STATE_OPEN = 7;

		// Token: 0x0401FB58 RID: 129880
		[Token(Token = "0x401FB58")]
		[NonSerialized]
		public const int ON_SHUFFLE_STATE_CLOSE = 8;

		// Token: 0x0401FB59 RID: 129881
		[Token(Token = "0x401FB59")]
		[NonSerialized]
		public const int ON_SHUFFLE_PROF_CHANGE = 9;

		// Token: 0x0401FB5A RID: 129882
		[Token(Token = "0x401FB5A")]
		[NonSerialized]
		public const int ON_SHUFFLE_STATE_CHANGE = 10;

		// Token: 0x0401FB5B RID: 129883
		[Token(Token = "0x401FB5B")]
		[NonSerialized]
		public const int ON_CLICK_ENSURE = 11;

		// Token: 0x0401FB5C RID: 129884
		[Token(Token = "0x401FB5C")]
		[NonSerialized]
		public const int ON_CLICK_CLEAR = 12;

		// Token: 0x0401FB5D RID: 129885
		[Token(Token = "0x401FB5D")]
		[NonSerialized]
		public const int TO_CHAR_DETAIL = 13;

		// Token: 0x0401FB5E RID: 129886
		[Token(Token = "0x401FB5E")]
		[NonSerialized]
		public const int TO_FOOD_INFO = 14;

		// Token: 0x0401FB5F RID: 129887
		[Token(Token = "0x401FB5F")]
		[NonSerialized]
		public const int ON_PRODUCE_DRINK = 15;

		// Token: 0x0401FB60 RID: 129888
		[Token(Token = "0x401FB60")]
		[NonSerialized]
		public const int ON_POP_VIEW_OPEN = 16;

		// Token: 0x0401FB61 RID: 129889
		[Token(Token = "0x401FB61")]
		[NonSerialized]
		public const int ON_POP_VIEW_CLOSE = 17;

		// Token: 0x0401FB62 RID: 129890
		[Token(Token = "0x401FB62")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2AdminCharSelectStateBean m_stateBean;

		// Token: 0x0401FB63 RID: 129891
		[Token(Token = "0x401FB63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401FB64 RID: 129892
		[Token(Token = "0x401FB64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401FB65 RID: 129893
		[Token(Token = "0x401FB65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401FB66 RID: 129894
		[Token(Token = "0x401FB66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401FB67 RID: 129895
		[Token(Token = "0x401FB67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenCharDetail;

		// Token: 0x0401FB68 RID: 129896
		[Token(Token = "0x401FB68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOpenEatFood;

		// Token: 0x0401FB69 RID: 129897
		[Token(Token = "0x401FB69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401FB6A RID: 129898
		[Token(Token = "0x401FB6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnEnsure;

		// Token: 0x0401FB6B RID: 129899
		[Token(Token = "0x401FB6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DismissWithEnsure;

		// Token: 0x0401FB6C RID: 129900
		[Token(Token = "0x401FB6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnProduceDrink;

		// Token: 0x0401FB6D RID: 129901
		[Token(Token = "0x401FB6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSwitchPopView;

		// Token: 0x0401FB6E RID: 129902
		[Token(Token = "0x401FB6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
