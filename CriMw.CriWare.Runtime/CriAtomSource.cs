using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AddComponentMenu("CRIWARE/CRI Atom Source")]
	public class CriAtomSource : CriAtomSourceBase
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public string cueName
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public string cueSheet
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			set
			{
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x36D5610", Offset = "0x36D4210", VA = "0x1836D5610", Slot = "12")]
		public override CriAtomExPlayback Play()
		{
			return default(CriAtomExPlayback);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x36D5480", Offset = "0x36D4080", VA = "0x1836D5480", Slot = "13")]
		protected override CriAtomExAcb GetAcb()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x36D5550", Offset = "0x36D4150", VA = "0x1836D5550", Slot = "14")]
		protected override void PlayOnStart()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x36D54C0", Offset = "0x36D40C0", VA = "0x1836D54C0")]
		private IEnumerator PlayAsync(string cueName)
		{
			return null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x36D5700", Offset = "0x36D4300", VA = "0x1836D5700")]
		public CriAtomSource()
		{
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _cueName;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _cueSheet;
	}
}
