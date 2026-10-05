using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006099 RID: 24729
	[Token(Token = "0x2006099")]
	public class CarvingInputMaterialAreaView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023C88 RID: 146568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C88")]
		[Address(RVA = "0x1E78410", Offset = "0x1E77010", VA = "0x181E78410")]
		public void Render(CarvingInputMaterialModel model)
		{
		}

		// Token: 0x06023C89 RID: 146569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C89")]
		[Address(RVA = "0x1E78740", Offset = "0x1E77340", VA = "0x181E78740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023C8A RID: 146570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C8A")]
		[Address(RVA = "0x1E788E0", Offset = "0x1E774E0", VA = "0x181E788E0")]
		public CarvingInputMaterialAreaView()
		{
		}

		// Token: 0x040319CA RID: 203210
		[Token(Token = "0x40319CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Transform> _materialSlots;

		// Token: 0x040319CB RID: 203211
		[Token(Token = "0x40319CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CarvingMaterialItem _materialItemPrefab;

		// Token: 0x040319CC RID: 203212
		[Token(Token = "0x40319CC")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x040319CD RID: 203213
		[Token(Token = "0x40319CD")]
		[FieldOffset(Offset = "0x30")]
		private List<CarvingMaterialItem> m_items;

		// Token: 0x040319CE RID: 203214
		[Token(Token = "0x40319CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040319CF RID: 203215
		[Token(Token = "0x40319CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040319D0 RID: 203216
		[Token(Token = "0x40319D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
