using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A94 RID: 31380
	[Token(Token = "0x2007A94")]
	public class Act12sideEmptyState : State
	{
		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x0602BF51 RID: 180049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006706")]
		protected string activityId
		{
			[Token(Token = "0x602BF51")]
			[Address(RVA = "0x27D8C50", Offset = "0x27D7850", VA = "0x1827D8C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x0602BF52 RID: 180050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006707")]
		protected Act12sideStageController actController
		{
			[Token(Token = "0x602BF52")]
			[Address(RVA = "0x27D8A50", Offset = "0x27D7650", VA = "0x1827D8A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BF53 RID: 180051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF53")]
		[Address(RVA = "0x27D8240", Offset = "0x27D6E40", VA = "0x1827D8240", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF54 RID: 180052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF54")]
		[Address(RVA = "0x27D82A0", Offset = "0x27D6EA0", VA = "0x1827D82A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BF55 RID: 180053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF55")]
		[Address(RVA = "0x27D8370", Offset = "0x27D6F70", VA = "0x1827D8370", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BF56 RID: 180054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF56")]
		[Address(RVA = "0x27D8890", Offset = "0x27D7490", VA = "0x1827D8890")]
		private void _RegisterToMedalState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BF57 RID: 180055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF57")]
		[Address(RVA = "0x27D86A0", Offset = "0x27D72A0", VA = "0x1827D86A0")]
		private void _RegisterToFavorUpState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BF58 RID: 180056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF58")]
		[Address(RVA = "0x27D8540", Offset = "0x27D7140", VA = "0x1827D8540")]
		private void _FetchStageController()
		{
		}

		// Token: 0x0602BF59 RID: 180057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF59")]
		[Address(RVA = "0x27D89F0", Offset = "0x27D75F0", VA = "0x1827D89F0")]
		public Act12sideEmptyState()
		{
		}

		// Token: 0x0602BF5A RID: 180058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF5A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BF5B RID: 180059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF5B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403FAD0 RID: 260816
		[Token(Token = "0x403FAD0")]
		[FieldOffset(Offset = "0x50")]
		private Act12sideStageController m_stageController;

		// Token: 0x0403FAD1 RID: 260817
		[Token(Token = "0x403FAD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403FAD2 RID: 260818
		[Token(Token = "0x403FAD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403FAD3 RID: 260819
		[Token(Token = "0x403FAD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FAD4 RID: 260820
		[Token(Token = "0x403FAD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FAD5 RID: 260821
		[Token(Token = "0x403FAD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403FAD6 RID: 260822
		[Token(Token = "0x403FAD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterToMedalState;

		// Token: 0x0403FAD7 RID: 260823
		[Token(Token = "0x403FAD7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RegisterToFavorUpState;

		// Token: 0x0403FAD8 RID: 260824
		[Token(Token = "0x403FAD8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403FAD9 RID: 260825
		[Token(Token = "0x403FAD9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
