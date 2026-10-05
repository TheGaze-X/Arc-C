using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public abstract class CriMonoBehaviour : MonoBehaviour
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000043AC File Offset: 0x000025AC
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009D")]
		public Guid guid
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x36FB5A0", Offset = "0x36FA1A0", VA = "0x1836FB5A0")]
		public CriMonoBehaviour()
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x3704150", Offset = "0x3702D50", VA = "0x183704150", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x3704100", Offset = "0x3702D00", VA = "0x183704100", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000826 RID: 2086
		[Token(Token = "0x6000826")]
		public abstract void CriInternalUpdate();

		// Token: 0x06000827 RID: 2087
		[Token(Token = "0x6000827")]
		public abstract void CriInternalLateUpdate();
	}
}
