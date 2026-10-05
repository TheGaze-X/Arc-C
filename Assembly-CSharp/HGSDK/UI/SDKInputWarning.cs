using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HGSDK.UI
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public class SDKInputWarning : MonoBehaviour, IWarningHint
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012C")]
		public bool isShown
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0xFD66E0", Offset = "0xFD52E0", VA = "0x180FD66E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x25364F0", Offset = "0x25350F0", VA = "0x1825364F0")]
			private set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x1700012D")]
		public bool isValidatedOK
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x2536490", Offset = "0x2535090", VA = "0x182536490", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
		public void RegisterOnValidation(Func<string, bool> onValidation)
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x25362F0", Offset = "0x2534EF0", VA = "0x1825362F0", Slot = "5")]
		public bool Validate(bool forceShowIfNotPass)
		{
			return default(bool);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x25361A0", Offset = "0x2534DA0", VA = "0x1825361A0")]
		public void SetWarningByResult()
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x25361D0", Offset = "0x2534DD0", VA = "0x1825361D0")]
		private void Start()
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x25363F0", Offset = "0x2534FF0", VA = "0x1825363F0")]
		private void _OnValidate(string content)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2536370", Offset = "0x2534F70", VA = "0x182536370")]
		private void _OnValidate(string content, bool forceShowIfNotPass)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2536480", Offset = "0x2535080", VA = "0x182536480")]
		public SDKInputWarning()
		{
		}

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _input;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _doNotShowWhenEmpty;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x28")]
		private Func<string, bool> m_onValidation;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x30")]
		private bool m_setUpByOutside;
	}
}
