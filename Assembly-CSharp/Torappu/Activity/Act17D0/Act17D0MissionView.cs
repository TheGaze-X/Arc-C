using System;
using Il2CppDummyDll;
using Torappu.Activity.Act9D0;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act17D0
{
	// Token: 0x020079BC RID: 31164
	[Token(Token = "0x20079BC")]
	public class Act17D0MissionView : Act9D0MissionBaseView
	{
		// Token: 0x0602BB5D RID: 179037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB5D")]
		[Address(RVA = "0x279F920", Offset = "0x279E520", VA = "0x18279F920", Slot = "4")]
		public override void Render(Act9D0MissionStateBean stateBean)
		{
		}

		// Token: 0x0602BB5E RID: 179038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB5E")]
		[Address(RVA = "0x279FB50", Offset = "0x279E750", VA = "0x18279FB50")]
		public Act17D0MissionView()
		{
		}

		// Token: 0x0403F3C7 RID: 259015
		[Token(Token = "0x403F3C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403F3C8 RID: 259016
		[Token(Token = "0x403F3C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageProgress;

		// Token: 0x0403F3C9 RID: 259017
		[Token(Token = "0x403F3C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act9D0MissionGroupAdapter _missionGroupAdapter;

		// Token: 0x0403F3CA RID: 259018
		[Token(Token = "0x403F3CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objCanClaimAll;

		// Token: 0x0403F3CB RID: 259019
		[Token(Token = "0x403F3CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objCantClaimAll;

		// Token: 0x0403F3CC RID: 259020
		[Token(Token = "0x403F3CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F3CD RID: 259021
		[Token(Token = "0x403F3CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
