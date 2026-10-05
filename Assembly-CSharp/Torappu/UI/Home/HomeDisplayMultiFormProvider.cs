using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B50 RID: 19280
	[Token(Token = "0x2004B50")]
	public abstract class HomeDisplayMultiFormProvider : IHotfixable
	{
		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x0601D088 RID: 118920 RVA: 0x000AA148 File Offset: 0x000A8348
		// (set) Token: 0x0601D089 RID: 118921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004447")]
		public MultiFormLoadParam loadParam
		{
			[Token(Token = "0x601D088")]
			[Address(RVA = "0x1671090", Offset = "0x166FC90", VA = "0x181671090")]
			[CompilerGenerated]
			get
			{
				return default(MultiFormLoadParam);
			}
			[Token(Token = "0x601D089")]
			[Address(RVA = "0x1671170", Offset = "0x166FD70", VA = "0x181671170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x0601D08A RID: 118922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004448")]
		public string mainId
		{
			[Token(Token = "0x601D08A")]
			[Address(RVA = "0x1671110", Offset = "0x166FD10", VA = "0x181671110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x0601D08B RID: 118923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004449")]
		public string formId
		{
			[Token(Token = "0x601D08B")]
			[Address(RVA = "0x1671030", Offset = "0x166FC30", VA = "0x181671030")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D08C RID: 118924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D08C")]
		[Address(RVA = "0x1670300", Offset = "0x166EF00", VA = "0x181670300")]
		public void Bind(IMultiFormHandler handler)
		{
		}

		// Token: 0x0601D08D RID: 118925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D08D")]
		[Address(RVA = "0x1670BF0", Offset = "0x166F7F0", VA = "0x181670BF0")]
		private void _Unbind(IMultiFormHandler handler)
		{
		}

		// Token: 0x0601D08E RID: 118926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D08E")]
		[Address(RVA = "0x16704C0", Offset = "0x166F0C0", VA = "0x1816704C0")]
		public void Rebind(HomeDisplayMultiFormProvider oldProvider)
		{
		}

		// Token: 0x0601D08F RID: 118927 RVA: 0x000AA160 File Offset: 0x000A8360
		[Token(Token = "0x601D08F")]
		[Address(RVA = "0x1670C80", Offset = "0x166F880", VA = "0x181670C80")]
		protected bool _UpdateData()
		{
			return default(bool);
		}

		// Token: 0x0601D090 RID: 118928
		[Token(Token = "0x601D090")]
		protected abstract void _RefreshActiveForm();

		// Token: 0x0601D091 RID: 118929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D091")]
		[Address(RVA = "0x1670B30", Offset = "0x166F730", VA = "0x181670B30", Slot = "5")]
		protected virtual void _Pause()
		{
		}

		// Token: 0x0601D092 RID: 118930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D092")]
		[Address(RVA = "0x1670B90", Offset = "0x166F790", VA = "0x181670B90", Slot = "6")]
		protected virtual void _Resume()
		{
		}

		// Token: 0x0601D093 RID: 118931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D093")]
		[Address(RVA = "0x16703A0", Offset = "0x166EFA0", VA = "0x1816703A0")]
		public void NotifyFormChanged(bool isFastMode = false)
		{
		}

		// Token: 0x0601D094 RID: 118932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D094")]
		[Address(RVA = "0x1670870", Offset = "0x166F470", VA = "0x181670870")]
		private void _NotifyHandlers(bool isReset)
		{
		}

		// Token: 0x0601D095 RID: 118933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D095")]
		[Address(RVA = "0x1670F80", Offset = "0x166FB80", VA = "0x181670F80")]
		protected HomeDisplayMultiFormProvider()
		{
		}

		// Token: 0x0402614D RID: 155981
		[Token(Token = "0x402614D")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_isActive;

		// Token: 0x0402614F RID: 155983
		[Token(Token = "0x402614F")]
		[FieldOffset(Offset = "0x28")]
		protected HomeDisplayMultiFormRawData m_rawData;

		// Token: 0x04026150 RID: 155984
		[Token(Token = "0x4026150")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedMainId;

		// Token: 0x04026151 RID: 155985
		[Token(Token = "0x4026151")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedFormId;

		// Token: 0x04026152 RID: 155986
		[Token(Token = "0x4026152")]
		[FieldOffset(Offset = "0x40")]
		protected string m_activeFormId;

		// Token: 0x04026153 RID: 155987
		[Token(Token = "0x4026153")]
		[FieldOffset(Offset = "0x48")]
		protected HomeDisplayMultiFormItemModel m_activeFormModel;

		// Token: 0x04026154 RID: 155988
		[Token(Token = "0x4026154")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<IMultiFormHandler> m_handlers;

		// Token: 0x04026155 RID: 155989
		[Token(Token = "0x4026155")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loadParam;

		// Token: 0x04026156 RID: 155990
		[Token(Token = "0x4026156")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loadParam;

		// Token: 0x04026157 RID: 155991
		[Token(Token = "0x4026157")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mainId;

		// Token: 0x04026158 RID: 155992
		[Token(Token = "0x4026158")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_formId;

		// Token: 0x04026159 RID: 155993
		[Token(Token = "0x4026159")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0402615A RID: 155994
		[Token(Token = "0x402615A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Unbind;

		// Token: 0x0402615B RID: 155995
		[Token(Token = "0x402615B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Rebind;

		// Token: 0x0402615C RID: 155996
		[Token(Token = "0x402615C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0402615D RID: 155997
		[Token(Token = "0x402615D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Pause;

		// Token: 0x0402615E RID: 155998
		[Token(Token = "0x402615E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Resume;

		// Token: 0x0402615F RID: 155999
		[Token(Token = "0x402615F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyFormChanged;

		// Token: 0x04026160 RID: 156000
		[Token(Token = "0x4026160")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NotifyHandlers;

		// Token: 0x04026161 RID: 156001
		[Token(Token = "0x4026161")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
