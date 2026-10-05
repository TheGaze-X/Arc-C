using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003804 RID: 14340
	[Token(Token = "0x2003804")]
	public class UIInputTextLimit : MonoBehaviour
	{
		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x06016B72 RID: 93042 RVA: 0x00092760 File Offset: 0x00090960
		[Token(Token = "0x17003652")]
		private int _MaxTextCount
		{
			[Token(Token = "0x6016B72")]
			[Address(RVA = "0xF174A0", Offset = "0xF160A0", VA = "0x180F174A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06016B73 RID: 93043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B73")]
		[Address(RVA = "0xF17200", Offset = "0xF15E00", VA = "0x180F17200")]
		public void OnValueChanged(string curText)
		{
		}

		// Token: 0x06016B74 RID: 93044 RVA: 0x00092778 File Offset: 0x00090978
		[Token(Token = "0x6016B74")]
		[Address(RVA = "0xF17280", Offset = "0xF15E80", VA = "0x180F17280")]
		private bool _LimitText(string text, out string newText)
		{
			return default(bool);
		}

		// Token: 0x06016B75 RID: 93045 RVA: 0x00092790 File Offset: 0x00090990
		[Token(Token = "0x6016B75")]
		[Address(RVA = "0xF17250", Offset = "0xF15E50", VA = "0x180F17250")]
		private static int _CalcCharCount(char c)
		{
			return 0;
		}

		// Token: 0x06016B76 RID: 93046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B76")]
		[Address(RVA = "0xF17430", Offset = "0xF16030", VA = "0x180F17430")]
		public UIInputTextLimit()
		{
		}

		// Token: 0x0401B5F4 RID: 112116
		[Token(Token = "0x401B5F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Char limit count, zero or negative if don't limit")]
		private int _limitCount;

		// Token: 0x0401B5F5 RID: 112117
		[Token(Token = "0x401B5F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputField _targetInput;

		// Token: 0x0401B5F6 RID: 112118
		[Token(Token = "0x401B5F6")]
		[FieldOffset(Offset = "0x28")]
		private StringBuilder m_sharedBuilder;
	}
}
