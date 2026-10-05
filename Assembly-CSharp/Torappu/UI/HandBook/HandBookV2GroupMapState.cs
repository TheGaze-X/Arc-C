using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066EE RID: 26350
	[Token(Token = "0x20066EE")]
	public class HandBookV2GroupMapState : PopupFadeState
	{
		// Token: 0x06025D1C RID: 154908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D1C")]
		[Address(RVA = "0x20C13B0", Offset = "0x20BFFB0", VA = "0x1820C13B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025D1D RID: 154909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D1D")]
		[Address(RVA = "0x20C1530", Offset = "0x20C0130", VA = "0x1820C1530", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06025D1E RID: 154910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D1E")]
		[Address(RVA = "0x20C1900", Offset = "0x20C0500", VA = "0x1820C1900")]
		public void ToOtherGroupByForceId(string forceId)
		{
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D1F")]
		[Address(RVA = "0x20C1410", Offset = "0x20C0010", VA = "0x1820C1410")]
		public void OnClick(HandBookV2MapCardView cardView)
		{
		}

		// Token: 0x06025D20 RID: 154912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D20")]
		[Address(RVA = "0x20C1730", Offset = "0x20C0330", VA = "0x1820C1730", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025D21 RID: 154913 RVA: 0x000C9288 File Offset: 0x000C7488
		[Token(Token = "0x6025D21")]
		[Address(RVA = "0x20C1FA0", Offset = "0x20C0BA0", VA = "0x1820C1FA0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06025D22 RID: 154914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D22")]
		[Address(RVA = "0x20C15D0", Offset = "0x20C01D0", VA = "0x1820C15D0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D23")]
		[Address(RVA = "0x20C2010", Offset = "0x20C0C10", VA = "0x1820C2010")]
		public HandBookV2GroupMapState()
		{
		}

		// Token: 0x06025D27 RID: 154919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D27")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06025D28 RID: 154920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D28")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025D29 RID: 154921 RVA: 0x000C92A0 File Offset: 0x000C74A0
		[Token(Token = "0x6025D29")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06025D2A RID: 154922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D2A")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0403529A RID: 217754
		[Token(Token = "0x403529A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookV2GroupMapStateBean _stateBean;

		// Token: 0x0403529B RID: 217755
		[Token(Token = "0x403529B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContent;

		// Token: 0x0403529C RID: 217756
		[Token(Token = "0x403529C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HandBookV2MapGroupHolder _holder;

		// Token: 0x0403529D RID: 217757
		[Token(Token = "0x403529D")]
		[FieldOffset(Offset = "0x88")]
		private HandBookV2MapCardView m_cacheCard;

		// Token: 0x0403529E RID: 217758
		[Token(Token = "0x403529E")]
		[FieldOffset(Offset = "0x90")]
		private string m_cacheForceId;

		// Token: 0x0403529F RID: 217759
		[Token(Token = "0x403529F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040352A0 RID: 217760
		[Token(Token = "0x40352A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040352A1 RID: 217761
		[Token(Token = "0x40352A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToOtherGroupByForceId;

		// Token: 0x040352A2 RID: 217762
		[Token(Token = "0x40352A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040352A3 RID: 217763
		[Token(Token = "0x40352A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040352A4 RID: 217764
		[Token(Token = "0x40352A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x040352A5 RID: 217765
		[Token(Token = "0x40352A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040352A6 RID: 217766
		[Token(Token = "0x40352A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
