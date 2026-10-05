using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004068 RID: 16488
	[Token(Token = "0x2004068")]
	public class SandboxV2AdminMainTypeDefine<TypeEnum> where TypeEnum : struct, IComparable, IConvertible, IFormattable
	{
		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x06019811 RID: 104465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CC2")]
		public string title
		{
			[Token(Token = "0x6019811")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019812 RID: 104466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019812")]
		public SandboxV2AdminMainTypeDefine()
		{
		}

		// Token: 0x0401FCA1 RID: 130209
		[Token(Token = "0x401FCA1")]
		[FieldOffset(Offset = "0x0")]
		public TypeEnum type;

		// Token: 0x0401FCA2 RID: 130210
		[Token(Token = "0x401FCA2")]
		[FieldOffset(Offset = "0x0")]
		public Text titleSrc;

		// Token: 0x0401FCA3 RID: 130211
		[Token(Token = "0x401FCA3")]
		[FieldOffset(Offset = "0x0")]
		public Sprite icon;
	}
}
