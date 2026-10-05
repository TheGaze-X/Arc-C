using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007289 RID: 29321
	[Token(Token = "0x2007289")]
	public class Act4D0ZoneMapPlugin : StageZoneMapStatePlugin
	{
		// Token: 0x0602986E RID: 170094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602986E")]
		[Address(RVA = "0x24E3A60", Offset = "0x24E2660", VA = "0x1824E3A60", Slot = "4")]
		public override void UpdateStatus(string actId, StagePage page, ZoneViewProperty zoneProp)
		{
		}

		// Token: 0x0602986F RID: 170095 RVA: 0x000D5D68 File Offset: 0x000D3F68
		[Token(Token = "0x602986F")]
		[Address(RVA = "0x24E3D00", Offset = "0x24E2900", VA = "0x1824E3D00")]
		private bool _CheckIfToShowOnZone(string actid, ZoneViewProperty zoneProp)
		{
			return default(bool);
		}

		// Token: 0x06029870 RID: 170096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029870")]
		[Address(RVA = "0x24E3E50", Offset = "0x24E2A50", VA = "0x1824E3E50")]
		public Act4D0ZoneMapPlugin()
		{
		}

		// Token: 0x0403B57B RID: 243067
		[Token(Token = "0x403B57B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403B57C RID: 243068
		[Token(Token = "0x403B57C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _viewRoot;

		// Token: 0x0403B57D RID: 243069
		[Token(Token = "0x403B57D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0403B57E RID: 243070
		[Token(Token = "0x403B57E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckIfToShowOnZone;

		// Token: 0x0403B57F RID: 243071
		[Token(Token = "0x403B57F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
