using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007283 RID: 29315
	[Token(Token = "0x2007283")]
	public class Activity4D0StoryItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602985B RID: 170075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602985B")]
		[Address(RVA = "0x24EAF20", Offset = "0x24E9B20", VA = "0x1824EAF20")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602985C RID: 170076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602985C")]
		[Address(RVA = "0x24EAFF0", Offset = "0x24E9BF0", VA = "0x1824EAFF0")]
		public void Refresh(Act4D0StoryItemViewModel data, Action<int> callback)
		{
		}

		// Token: 0x0602985D RID: 170077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602985D")]
		[Address(RVA = "0x24EB2D0", Offset = "0x24E9ED0", VA = "0x1824EB2D0")]
		public Activity4D0StoryItem()
		{
		}

		// Token: 0x0403B531 RID: 242993
		[Token(Token = "0x403B531")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403B532 RID: 242994
		[Token(Token = "0x403B532")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleB;

		// Token: 0x0403B533 RID: 242995
		[Token(Token = "0x403B533")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalRoot;

		// Token: 0x0403B534 RID: 242996
		[Token(Token = "0x403B534")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newHintRoot;

		// Token: 0x0403B535 RID: 242997
		[Token(Token = "0x403B535")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockRoot;

		// Token: 0x0403B536 RID: 242998
		[Token(Token = "0x403B536")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _unlockCondition;

		// Token: 0x0403B537 RID: 242999
		[Token(Token = "0x403B537")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _readStoryButton;

		// Token: 0x0403B538 RID: 243000
		[Token(Token = "0x403B538")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lockDisableRoot;

		// Token: 0x0403B539 RID: 243001
		[Token(Token = "0x403B539")]
		[FieldOffset(Offset = "0x58")]
		private Act4D0StoryItemViewModel m_data;

		// Token: 0x0403B53A RID: 243002
		[Token(Token = "0x403B53A")]
		[FieldOffset(Offset = "0x60")]
		private Action<int> m_callback;

		// Token: 0x0403B53B RID: 243003
		[Token(Token = "0x403B53B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403B53C RID: 243004
		[Token(Token = "0x403B53C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403B53D RID: 243005
		[Token(Token = "0x403B53D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
