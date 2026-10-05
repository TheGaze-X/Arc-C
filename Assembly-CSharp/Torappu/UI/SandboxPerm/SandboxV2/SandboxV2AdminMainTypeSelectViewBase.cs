using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004069 RID: 16489
	[Token(Token = "0x2004069")]
	public abstract class SandboxV2AdminMainTypeSelectViewBase<TypeEnum, PropType> : DataBinder<PropType>, IHotfixable where TypeEnum : struct, IComparable, IConvertible, IFormattable where PropType : IBindProperty
	{
		// Token: 0x06019813 RID: 104467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019813")]
		protected void InitBaseIfNot(bool forceReset = false)
		{
		}

		// Token: 0x06019814 RID: 104468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019814")]
		protected void SetRacerBagNameText(string racerBagName)
		{
		}

		// Token: 0x06019815 RID: 104469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019815")]
		private void _EventSelectChanged(int idx)
		{
		}

		// Token: 0x06019816 RID: 104470
		[Token(Token = "0x6019816")]
		protected abstract IList<SandboxV2AdminMainTypeDefine<TypeEnum>> GetDefinedTypeList();

		// Token: 0x06019817 RID: 104471 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
		[Token(Token = "0x6019817")]
		protected virtual bool CheckTypeActive(TypeEnum type)
		{
			return default(bool);
		}

		// Token: 0x06019818 RID: 104472
		[Token(Token = "0x6019818")]
		protected abstract void OnTypeSelectChanged(TypeEnum selectType);

		// Token: 0x06019819 RID: 104473 RVA: 0x0009E5E0 File Offset: 0x0009C7E0
		[Token(Token = "0x6019819")]
		protected virtual bool CheckIfShowRacingInfoBtn()
		{
			return default(bool);
		}

		// Token: 0x0601981A RID: 104474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601981A")]
		public void SetSelectType(TypeEnum t)
		{
		}

		// Token: 0x0601981B RID: 104475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601981B")]
		protected GameObject TutorialOnly_GetButtonGO(TypeEnum t)
		{
			return null;
		}

		// Token: 0x0601981C RID: 104476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601981C")]
		protected SandboxV2AdminMainTypeSelectViewBase()
		{
		}

		// Token: 0x0401FCA4 RID: 130212
		[Token(Token = "0x401FCA4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SandboxV2AdminMainTypeSelector _selectorPrefab;

		// Token: 0x0401FCA5 RID: 130213
		[Token(Token = "0x401FCA5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0401FCA6 RID: 130214
		[Token(Token = "0x401FCA6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Color _selTitleClr;

		// Token: 0x0401FCA7 RID: 130215
		[Token(Token = "0x401FCA7")]
		[FieldOffset(Offset = "0x0")]
		private SandboxV2AdminMainTypeSelector m_selector;

		// Token: 0x0401FCA8 RID: 130216
		[Token(Token = "0x401FCA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitBaseIfNot;

		// Token: 0x0401FCA9 RID: 130217
		[Token(Token = "0x401FCA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRacerBagNameText;

		// Token: 0x0401FCAA RID: 130218
		[Token(Token = "0x401FCAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EventSelectChanged;

		// Token: 0x0401FCAB RID: 130219
		[Token(Token = "0x401FCAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x0401FCAC RID: 130220
		[Token(Token = "0x401FCAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfShowRacingInfoBtn;

		// Token: 0x0401FCAD RID: 130221
		[Token(Token = "0x401FCAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelectType;

		// Token: 0x0401FCAE RID: 130222
		[Token(Token = "0x401FCAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetButtonGO;

		// Token: 0x0401FCAF RID: 130223
		[Token(Token = "0x401FCAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
