using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F91 RID: 8081
	[Token(Token = "0x2001F91")]
	public class ToggleGroupWatcher : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C8D5 RID: 51413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D5")]
		[Address(RVA = "0x3499F00", Offset = "0x3498B00", VA = "0x183499F00")]
		private void Start()
		{
		}

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D6")]
		[Address(RVA = "0x349A0E0", Offset = "0x3498CE0", VA = "0x18349A0E0")]
		private void _HandleToggleChanged(TwoStateToggle toggle, int index, TwoStateToggle.State state)
		{
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D7")]
		[Address(RVA = "0x3499CA0", Offset = "0x34988A0", VA = "0x183499CA0")]
		public void RegisterOnToggleGroupChange(Action<int> onGroupChange)
		{
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x00048F90 File Offset: 0x00047190
		[Token(Token = "0x600C8D8")]
		[Address(RVA = "0x3499BA0", Offset = "0x34987A0", VA = "0x183499BA0")]
		public int GetActiveToggleIndex()
		{
			return 0;
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8D9")]
		[Address(RVA = "0x3499D20", Offset = "0x3498920", VA = "0x183499D20")]
		public void SetSelectedIndex(int index)
		{
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8DA")]
		[Address(RVA = "0x349A380", Offset = "0x3498F80", VA = "0x18349A380")]
		public ToggleGroupWatcher()
		{
		}

		// Token: 0x0400CF66 RID: 53094
		[Token(Token = "0x400CF66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle[] _toggles;

		// Token: 0x0400CF67 RID: 53095
		[Token(Token = "0x400CF67")]
		[FieldOffset(Offset = "0x20")]
		private Action<int> m_onToggleIndexChanged;

		// Token: 0x0400CF68 RID: 53096
		[Token(Token = "0x400CF68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400CF69 RID: 53097
		[Token(Token = "0x400CF69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleToggleChanged;

		// Token: 0x0400CF6A RID: 53098
		[Token(Token = "0x400CF6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterOnToggleGroupChange;

		// Token: 0x0400CF6B RID: 53099
		[Token(Token = "0x400CF6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetActiveToggleIndex;

		// Token: 0x0400CF6C RID: 53100
		[Token(Token = "0x400CF6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSelectedIndex;

		// Token: 0x0400CF6D RID: 53101
		[Token(Token = "0x400CF6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
