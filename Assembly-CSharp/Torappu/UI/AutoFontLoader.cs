using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020038C0 RID: 14528
	[Token(Token = "0x20038C0")]
	[Obsolete("即将删除，勿用！")]
	[RequireComponent(typeof(Text))]
	public class AutoFontLoader : MonoBehaviour
	{
		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x06016FB4 RID: 94132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170036E1")]
		public string fontName
		{
			[Token(Token = "0x6016FB4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016FB5 RID: 94133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FB5")]
		[Address(RVA = "0xF6D3F0", Offset = "0xF6BFF0", VA = "0x180F6D3F0")]
		private void Start()
		{
		}

		// Token: 0x06016FB6 RID: 94134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FB6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AutoFontLoader()
		{
		}

		// Token: 0x0401BBE3 RID: 113635
		[Token(Token = "0x401BBE3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _fontName;
	}
}
