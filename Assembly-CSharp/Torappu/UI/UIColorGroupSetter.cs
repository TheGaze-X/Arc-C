using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020039DA RID: 14810
	[Token(Token = "0x20039DA")]
	public class UIColorGroupSetter : MonoBehaviour
	{
		// Token: 0x0601763C RID: 95804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601763C")]
		[Address(RVA = "0xFBD120", Offset = "0xFBBD20", VA = "0x180FBD120")]
		public void RebuildGroupInfo()
		{
		}

		// Token: 0x0601763D RID: 95805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601763D")]
		[Address(RVA = "0xFBCDB0", Offset = "0xFBB9B0", VA = "0x180FBCDB0")]
		public void MixColor(Color mixColor, float weight)
		{
		}

		// Token: 0x0601763E RID: 95806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601763E")]
		[Address(RVA = "0xFBD320", Offset = "0xFBBF20", VA = "0x180FBD320")]
		public void SetColor(Color targetColor)
		{
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601763F")]
		[Address(RVA = "0xFBD1A0", Offset = "0xFBBDA0", VA = "0x180FBD1A0")]
		public void RecoverColor()
		{
		}

		// Token: 0x06017640 RID: 95808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017640")]
		[Address(RVA = "0xFBD5B0", Offset = "0xFBC1B0", VA = "0x180FBD5B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017641")]
		[Address(RVA = "0xFBD660", Offset = "0xFBC260", VA = "0x180FBD660")]
		private void _InitInfoRecursively(Transform root)
		{
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017642")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIColorGroupSetter()
		{
		}

		// Token: 0x0401C3F6 RID: 115702
		[Token(Token = "0x401C3F6")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<int, UIColorGroupSetter.InfoNode> m_colorDict;

		// Token: 0x0401C3F7 RID: 115703
		[Token(Token = "0x401C3F7")]
		[FieldOffset(Offset = "0x20")]
		private string m_currentColorSign;

		// Token: 0x020039DB RID: 14811
		[Token(Token = "0x20039DB")]
		private struct InfoNode
		{
			// Token: 0x17003809 RID: 14345
			// (get) Token: 0x06017643 RID: 95811 RVA: 0x00096468 File Offset: 0x00094668
			// (set) Token: 0x06017644 RID: 95812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003809")]
			public Color color
			{
				[Token(Token = "0x6017643")]
				[Address(RVA = "0xFB14C0", Offset = "0xFB00C0", VA = "0x180FB14C0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x6017644")]
				[Address(RVA = "0xFB15B0", Offset = "0xFB01B0", VA = "0x180FB15B0")]
				set
				{
				}
			}

			// Token: 0x0401C3F8 RID: 115704
			[Token(Token = "0x401C3F8")]
			[FieldOffset(Offset = "0x0")]
			public Color originColor;

			// Token: 0x0401C3F9 RID: 115705
			[Token(Token = "0x401C3F9")]
			[FieldOffset(Offset = "0x10")]
			public Image image;

			// Token: 0x0401C3FA RID: 115706
			[Token(Token = "0x401C3FA")]
			[FieldOffset(Offset = "0x18")]
			public Text text;
		}
	}
}
