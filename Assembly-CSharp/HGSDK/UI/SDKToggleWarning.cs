using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HGSDK.UI
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	public class SDKToggleWarning : MonoBehaviour, IWarningHint
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00003F30 File Offset: 0x00002130
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000135")]
		public bool isShown
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xFD66E0", Offset = "0xFD52E0", VA = "0x180FD66E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x25364F0", Offset = "0x25350F0", VA = "0x1825364F0")]
			private set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x17000136")]
		public bool isValidatedOK
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x2537B00", Offset = "0x2536700", VA = "0x182537B00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
		public void RegisterOnValidation(Func<bool, bool> onValidation)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2537A10", Offset = "0x2536610", VA = "0x182537A10", Slot = "5")]
		public bool Validate(bool forceShowIfNotPass)
		{
			return default(bool);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2537900", Offset = "0x2536500", VA = "0x182537900")]
		private void Start()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2537AA0", Offset = "0x25366A0", VA = "0x182537AA0")]
		private void _OnValidate(bool isOn)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SDKToggleWarning()
		{
		}

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _showOnStart;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x28")]
		private Func<bool, bool> m_onValidation;
	}
}
