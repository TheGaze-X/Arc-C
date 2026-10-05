using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C07 RID: 7175
	[Token(Token = "0x2001C07")]
	public class BuildingTrainPage : BuildingCommonPage, IValueMsgReceiver
	{
		// Token: 0x0600B2E4 RID: 45796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E4")]
		[Address(RVA = "0x32DB940", Offset = "0x32DA540", VA = "0x1832DB940")]
		private void _ReturnPage()
		{
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E5")]
		[Address(RVA = "0x32DB700", Offset = "0x32DA300", VA = "0x1832DB700", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E6")]
		[Address(RVA = "0x32DB9E0", Offset = "0x32DA5E0", VA = "0x1832DB9E0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E7")]
		[Address(RVA = "0x32DB7E0", Offset = "0x32DA3E0", VA = "0x1832DB7E0", Slot = "31")]
		public void OnMessage(int msg, ValueBundle param)
		{
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2E8")]
		[Address(RVA = "0x32DBB20", Offset = "0x32DA720", VA = "0x1832DBB20")]
		private IEnumerator _ResetToDefaultStateCoroutine()
		{
			return null;
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E9")]
		[Address(RVA = "0x32DBBD0", Offset = "0x32DA7D0", VA = "0x1832DBBD0")]
		public BuildingTrainPage()
		{
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2EB")]
		[Address(RVA = "0x327F490", Offset = "0x327E090", VA = "0x18327F490")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0400ADF0 RID: 44528
		[Token(Token = "0x400ADF0")]
		[NonSerialized]
		public const int MSG_TRAINEE_INVALID = 1;

		// Token: 0x0400ADF1 RID: 44529
		[Token(Token = "0x400ADF1")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400ADF2 RID: 44530
		[Token(Token = "0x400ADF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x0400ADF3 RID: 44531
		[Token(Token = "0x400ADF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0400ADF4 RID: 44532
		[Token(Token = "0x400ADF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0400ADF5 RID: 44533
		[Token(Token = "0x400ADF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400ADF6 RID: 44534
		[Token(Token = "0x400ADF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetToDefaultStateCoroutine;

		// Token: 0x0400ADF7 RID: 44535
		[Token(Token = "0x400ADF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
