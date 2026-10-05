using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A5 RID: 26277
	[Token(Token = "0x20066A5")]
	public class HandBookTeamEditor : MonoBehaviour
	{
		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x06025BEC RID: 154604 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
		[Token(Token = "0x17005967")]
		[HideInInspector]
		public int iconType
		{
			[Token(Token = "0x6025BEC")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025BED RID: 154605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BED")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookTeamEditor()
		{
		}

		// Token: 0x040350D6 RID: 217302
		[Token(Token = "0x40350D6")]
		[FieldOffset(Offset = "0x18")]
		public string powerId;

		// Token: 0x040350D7 RID: 217303
		[Token(Token = "0x40350D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookTeamEditor.leftrightType m_iconType;

		// Token: 0x040350D8 RID: 217304
		[Token(Token = "0x40350D8")]
		[FieldOffset(Offset = "0x28")]
		public HandBookTeamView teamView;

		// Token: 0x040350D9 RID: 217305
		[Token(Token = "0x40350D9")]
		[FieldOffset(Offset = "0x30")]
		public Transform teamDestination;

		// Token: 0x040350DA RID: 217306
		[Token(Token = "0x40350DA")]
		[FieldOffset(Offset = "0x38")]
		public Transform teamImage;

		// Token: 0x020066A6 RID: 26278
		[Token(Token = "0x20066A6")]
		public enum leftrightType
		{
			// Token: 0x040350DC RID: 217308
			[Token(Token = "0x40350DC")]
			left,
			// Token: 0x040350DD RID: 217309
			[Token(Token = "0x40350DD")]
			right
		}
	}
}
