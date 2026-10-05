using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C3 RID: 30915
	[Token(Token = "0x20078C3")]
	public class Act1LockStageLine : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x0602B5B2 RID: 177586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006573")]
		public string stageId
		{
			[Token(Token = "0x602B5B2")]
			[Address(RVA = "0x2732CF0", Offset = "0x27318F0", VA = "0x182732CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B5B3 RID: 177587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5B3")]
		[Address(RVA = "0x2732B90", Offset = "0x2731790", VA = "0x182732B90")]
		public void RenderLine(bool stageUnlocked, Color color)
		{
		}

		// Token: 0x0602B5B4 RID: 177588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5B4")]
		[Address(RVA = "0x2732C90", Offset = "0x2731890", VA = "0x182732C90")]
		public Act1LockStageLine()
		{
		}

		// Token: 0x0403EB27 RID: 256807
		[Token(Token = "0x403EB27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _lineImg;

		// Token: 0x0403EB28 RID: 256808
		[Token(Token = "0x403EB28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _stageId;

		// Token: 0x0403EB29 RID: 256809
		[Token(Token = "0x403EB29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403EB2A RID: 256810
		[Token(Token = "0x403EB2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderLine;

		// Token: 0x0403EB2B RID: 256811
		[Token(Token = "0x403EB2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
