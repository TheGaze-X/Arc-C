using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003758 RID: 14168
	[Token(Token = "0x2003758")]
	public abstract class AbstractSkillRangeButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601680D RID: 92173
		[Token(Token = "0x601680D")]
		protected abstract void _Render(UISkillRangeDisplayDialog.Options options);

		// Token: 0x0601680E RID: 92174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601680E")]
		[Address(RVA = "0xED7580", Offset = "0xED6180", VA = "0x180ED7580")]
		public void Render(UISkillRangeDisplayDialog.Options options)
		{
		}

		// Token: 0x0601680F RID: 92175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601680F")]
		[Address(RVA = "0xED7490", Offset = "0xED6090", VA = "0x180ED7490")]
		public void OnClickButton()
		{
		}

		// Token: 0x06016810 RID: 92176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016810")]
		[Address(RVA = "0xED7670", Offset = "0xED6270", VA = "0x180ED7670")]
		protected AbstractSkillRangeButtonView()
		{
		}

		// Token: 0x0401B1B9 RID: 111033
		[Token(Token = "0x401B1B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rootGo;

		// Token: 0x0401B1BA RID: 111034
		[Token(Token = "0x401B1BA")]
		[FieldOffset(Offset = "0x20")]
		private UISkillRangeDisplayDialog.Options m_cachedOptions;

		// Token: 0x0401B1BB RID: 111035
		[Token(Token = "0x401B1BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B1BC RID: 111036
		[Token(Token = "0x401B1BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickButton;

		// Token: 0x0401B1BD RID: 111037
		[Token(Token = "0x401B1BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
