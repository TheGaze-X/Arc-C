using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007794 RID: 30612
	[Token(Token = "0x2007794")]
	public class Act1VHalfIdleDepotBuffDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AFCF RID: 176079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFCF")]
		[Address(RVA = "0x26C7030", Offset = "0x26C5C30", VA = "0x1826C7030")]
		public void Render(Act1VHalfIdleCharBuffInfo buffInfo, int currLevel, bool isLast)
		{
		}

		// Token: 0x0602AFD0 RID: 176080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFD0")]
		[Address(RVA = "0x26C7410", Offset = "0x26C6010", VA = "0x1826C7410")]
		public Act1VHalfIdleDepotBuffDetailItemView()
		{
		}

		// Token: 0x0403E08D RID: 254093
		[Token(Token = "0x403E08D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _charCount;

		// Token: 0x0403E08E RID: 254094
		[Token(Token = "0x403E08E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelIconOver;

		// Token: 0x0403E08F RID: 254095
		[Token(Token = "0x403E08F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelIconCurr;

		// Token: 0x0403E090 RID: 254096
		[Token(Token = "0x403E090")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIconLock;

		// Token: 0x0403E091 RID: 254097
		[Token(Token = "0x403E091")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _level;

		// Token: 0x0403E092 RID: 254098
		[Token(Token = "0x403E092")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403E093 RID: 254099
		[Token(Token = "0x403E093")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _unlockedColor;

		// Token: 0x0403E094 RID: 254100
		[Token(Token = "0x403E094")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x0403E095 RID: 254101
		[Token(Token = "0x403E095")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _currLevelColor;

		// Token: 0x0403E096 RID: 254102
		[Token(Token = "0x403E096")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _line;

		// Token: 0x0403E097 RID: 254103
		[Token(Token = "0x403E097")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E098 RID: 254104
		[Token(Token = "0x403E098")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E099 RID: 254105
		[Token(Token = "0x403E099")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007795 RID: 30613
		[Token(Token = "0x2007795")]
		private enum RenderType
		{
			// Token: 0x0403E09B RID: 254107
			[Token(Token = "0x403E09B")]
			PASS,
			// Token: 0x0403E09C RID: 254108
			[Token(Token = "0x403E09C")]
			CURR,
			// Token: 0x0403E09D RID: 254109
			[Token(Token = "0x403E09D")]
			LOCK
		}
	}
}
