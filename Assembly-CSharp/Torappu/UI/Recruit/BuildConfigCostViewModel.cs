using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004701 RID: 18177
	[Token(Token = "0x2004701")]
	public class BuildConfigCostViewModel
	{
		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0601B907 RID: 112903 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B908 RID: 112904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419C")]
		public UIItemViewModel goldModel
		{
			[Token(Token = "0x601B907")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B908")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0601B909 RID: 112905 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B90A RID: 112906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419D")]
		public UIItemViewModel recruitLicenseModel
		{
			[Token(Token = "0x601B909")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B90A")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0601B90B RID: 112907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B90C RID: 112908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419E")]
		public List<UIItemViewModel> specialItemViewlModel
		{
			[Token(Token = "0x601B90B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B90C")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0601B90D RID: 112909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B90E RID: 112910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419F")]
		public string specialTagName
		{
			[Token(Token = "0x601B90D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B90E")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x0601B90F RID: 112911 RVA: 0x000A5810 File Offset: 0x000A3A10
		// (set) Token: 0x0601B910 RID: 112912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041A0")]
		public bool isSpecialViewModel
		{
			[Token(Token = "0x601B90F")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B910")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0601B911 RID: 112913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B911")]
		[Address(RVA = "0x14D9850", Offset = "0x14D8450", VA = "0x1814D9850")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B912 RID: 112914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B912")]
		[Address(RVA = "0x14D93D0", Offset = "0x14D7FD0", VA = "0x1814D93D0")]
		public void UpdateData(long costMillsec, int tagNum, bool specialTagState = false, [Optional] SpecialRecruitPool specialTagData)
		{
		}

		// Token: 0x0601B913 RID: 112915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B913")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildConfigCostViewModel()
		{
		}

		// Token: 0x04023B3C RID: 146236
		[Token(Token = "0x4023B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_goldReductRate;
	}
}
