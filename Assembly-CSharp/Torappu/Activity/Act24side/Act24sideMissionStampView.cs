using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075EE RID: 30190
	[Token(Token = "0x20075EE")]
	public class Act24sideMissionStampView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A816 RID: 174102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A816")]
		[Address(RVA = "0x262BF50", Offset = "0x262AB50", VA = "0x18262BF50")]
		public void Render(Act24sideMissionObjViewModel model)
		{
		}

		// Token: 0x0602A817 RID: 174103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A817")]
		[Address(RVA = "0x262C230", Offset = "0x262AE30", VA = "0x18262C230")]
		public Act24sideMissionStampView()
		{
		}

		// Token: 0x0403D2EC RID: 250604
		[Token(Token = "0x403D2EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _stamp;

		// Token: 0x0403D2ED RID: 250605
		[Token(Token = "0x403D2ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCompleted;

		// Token: 0x0403D2EE RID: 250606
		[Token(Token = "0x403D2EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _stampSchedule;

		// Token: 0x0403D2EF RID: 250607
		[Token(Token = "0x403D2EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _stampUnreceive;

		// Token: 0x0403D2F0 RID: 250608
		[Token(Token = "0x403D2F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _stampEntity;

		// Token: 0x0403D2F1 RID: 250609
		[Token(Token = "0x403D2F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _missionNumObj;

		// Token: 0x0403D2F2 RID: 250610
		[Token(Token = "0x403D2F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _missionNum;

		// Token: 0x0403D2F3 RID: 250611
		[Token(Token = "0x403D2F3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _stampUncompleteColor;

		// Token: 0x0403D2F4 RID: 250612
		[Token(Token = "0x403D2F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _stampCompleteColor;

		// Token: 0x0403D2F5 RID: 250613
		[Token(Token = "0x403D2F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D2F6 RID: 250614
		[Token(Token = "0x403D2F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
