using System;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067FD RID: 26621
	[Token(Token = "0x20067FD")]
	public class SandboxPermTopicResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x06026270 RID: 156272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A37")]
		public Sprite entryImg
		{
			[Token(Token = "0x6026270")]
			[Address(RVA = "0x2134060", Offset = "0x2132C60", VA = "0x182134060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x06026271 RID: 156273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A38")]
		public ZoneHomeSandboxPermTodoPluginBase todoPluginPrefab
		{
			[Token(Token = "0x6026271")]
			[Address(RVA = "0x21340C0", Offset = "0x2132CC0", VA = "0x1821340C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026272 RID: 156274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026272")]
		[Address(RVA = "0x2134000", Offset = "0x2132C00", VA = "0x182134000")]
		public SandboxPermTopicResHolder()
		{
		}

		// Token: 0x04035BC2 RID: 220098
		[Token(Token = "0x4035BC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _entryImg;

		// Token: 0x04035BC3 RID: 220099
		[Token(Token = "0x4035BC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZoneHomeSandboxPermTodoPluginBase _todoPluginPrefab;

		// Token: 0x04035BC4 RID: 220100
		[Token(Token = "0x4035BC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryImg;

		// Token: 0x04035BC5 RID: 220101
		[Token(Token = "0x4035BC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_todoPluginPrefab;

		// Token: 0x04035BC6 RID: 220102
		[Token(Token = "0x4035BC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
