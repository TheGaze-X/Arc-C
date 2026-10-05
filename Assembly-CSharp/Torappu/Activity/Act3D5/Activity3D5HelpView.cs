using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073C9 RID: 29641
	[Token(Token = "0x20073C9")]
	internal class Activity3D5HelpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029DF7 RID: 171511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DF7")]
		[Address(RVA = "0x257D910", Offset = "0x257C510", VA = "0x18257D910")]
		public void Refresh(string activityId, Action close)
		{
		}

		// Token: 0x06029DF8 RID: 171512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DF8")]
		[Address(RVA = "0x257DCC0", Offset = "0x257C8C0", VA = "0x18257DCC0")]
		private void _SynTime()
		{
		}

		// Token: 0x06029DF9 RID: 171513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DF9")]
		[Address(RVA = "0x257D860", Offset = "0x257C460", VA = "0x18257D860")]
		public void OnClose()
		{
		}

		// Token: 0x06029DFA RID: 171514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DFA")]
		[Address(RVA = "0x257E070", Offset = "0x257CC70", VA = "0x18257E070")]
		public Activity3D5HelpView()
		{
		}

		// Token: 0x0403C035 RID: 245813
		[Token(Token = "0x403C035")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _dailyTaskTimeLabel;

		// Token: 0x0403C036 RID: 245814
		[Token(Token = "0x403C036")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _limitTaskTimeLabel;

		// Token: 0x0403C037 RID: 245815
		[Token(Token = "0x403C037")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Activity3D5HelpDailyItem _dailyItem;

		// Token: 0x0403C038 RID: 245816
		[Token(Token = "0x403C038")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _limitContainer;

		// Token: 0x0403C039 RID: 245817
		[Token(Token = "0x403C039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Activity3D5HelpLimitItem _limitItemPrefab;

		// Token: 0x0403C03A RID: 245818
		[Token(Token = "0x403C03A")]
		[FieldOffset(Offset = "0x40")]
		private List<Activity3D5HelpLimitItem> m_limitItems;

		// Token: 0x0403C03B RID: 245819
		[Token(Token = "0x403C03B")]
		[FieldOffset(Offset = "0x48")]
		private string m_activityId;

		// Token: 0x0403C03C RID: 245820
		[Token(Token = "0x403C03C")]
		[FieldOffset(Offset = "0x50")]
		private Action m_close;

		// Token: 0x0403C03D RID: 245821
		[Token(Token = "0x403C03D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403C03E RID: 245822
		[Token(Token = "0x403C03E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SynTime;

		// Token: 0x0403C03F RID: 245823
		[Token(Token = "0x403C03F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClose;

		// Token: 0x0403C040 RID: 245824
		[Token(Token = "0x403C040")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
