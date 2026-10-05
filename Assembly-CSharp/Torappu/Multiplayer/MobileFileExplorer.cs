using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Multiplayer
{
	// Token: 0x0200155B RID: 5467
	[Token(Token = "0x200155B")]
	public class MobileFileExplorer : MonoBehaviour
	{
		// Token: 0x06007D05 RID: 32005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D05")]
		[Address(RVA = "0x2842820", Offset = "0x2841420", VA = "0x182842820")]
		public void Show(string rootPath, Action<string> slected, [Optional] string filter)
		{
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x00037728 File Offset: 0x00035928
		[Token(Token = "0x6007D06")]
		[Address(RVA = "0x2842D90", Offset = "0x2841990", VA = "0x182842D90")]
		private bool _ShowItemList(string dirPath)
		{
			return default(bool);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D07")]
		[Address(RVA = "0x2842910", Offset = "0x2841510", VA = "0x182842910")]
		private void _AddItem(string path, MobileFileExplorer.ItemType type)
		{
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D08")]
		[Address(RVA = "0x2842D20", Offset = "0x2841920", VA = "0x182842D20")]
		private void _ReturnParent()
		{
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D09")]
		[Address(RVA = "0x2842CB0", Offset = "0x28418B0", VA = "0x182842CB0")]
		private void _ClickDir(string path)
		{
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D0A")]
		[Address(RVA = "0x2842CC0", Offset = "0x28418C0", VA = "0x182842CC0")]
		private void _ClickFile(string path)
		{
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D0B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MobileFileExplorer()
		{
		}

		// Token: 0x04007DB8 RID: 32184
		[Token(Token = "0x4007DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _pathView;

		// Token: 0x04007DB9 RID: 32185
		[Token(Token = "0x4007DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrolll;

		// Token: 0x04007DBA RID: 32186
		[Token(Token = "0x4007DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _cellTemplate;

		// Token: 0x04007DBB RID: 32187
		[Token(Token = "0x4007DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_rootDir;

		// Token: 0x04007DBC RID: 32188
		[Token(Token = "0x4007DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_filter;

		// Token: 0x04007DBD RID: 32189
		[Token(Token = "0x4007DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<string> m_selected;

		// Token: 0x04007DBE RID: 32190
		[Token(Token = "0x4007DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_showedDir;

		// Token: 0x0200155C RID: 5468
		[Token(Token = "0x200155C")]
		private enum ItemType
		{
			// Token: 0x04007DC0 RID: 32192
			[Token(Token = "0x4007DC0")]
			ReturnParent,
			// Token: 0x04007DC1 RID: 32193
			[Token(Token = "0x4007DC1")]
			Directory,
			// Token: 0x04007DC2 RID: 32194
			[Token(Token = "0x4007DC2")]
			File
		}
	}
}
