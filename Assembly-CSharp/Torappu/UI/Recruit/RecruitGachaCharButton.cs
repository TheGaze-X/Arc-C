using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004756 RID: 18262
	[Token(Token = "0x2004756")]
	public class RecruitGachaCharButton : MonoBehaviour
	{
		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0601BA6D RID: 113261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BA6C RID: 113260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041BD")]
		public string CharId
		{
			[Token(Token = "0x601BA6D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x601BA6C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x0601BA6E RID: 113262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA6E")]
		[Address(RVA = "0x14FEC20", Offset = "0x14FD820", VA = "0x1814FEC20")]
		public void OnClick()
		{
		}

		// Token: 0x0601BA6F RID: 113263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA6F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitGachaCharButton()
		{
		}

		// Token: 0x04023E41 RID: 147009
		[Token(Token = "0x4023E41")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _charId;

		// Token: 0x04023E42 RID: 147010
		[Token(Token = "0x4023E42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EvolvePhase _evolvePhase;

		// Token: 0x04023E43 RID: 147011
		[Token(Token = "0x4023E43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _level;

		// Token: 0x04023E44 RID: 147012
		[Token(Token = "0x4023E44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _skillIndex;

		// Token: 0x04023E45 RID: 147013
		[Token(Token = "0x4023E45")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _skillLevel;
	}
}
