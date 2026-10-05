using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002883 RID: 10371
	[Token(Token = "0x2002883")]
	public abstract class ParamVariable
	{
		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06011456 RID: 70742 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06011457 RID: 70743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000071")]
		public event Action<ParamVariable, ParamVariable> raiseOnBBVariableChangedEvent
		{
			[Token(Token = "0x6011456")]
			[Address(RVA = "0x926EB0", Offset = "0x925AB0", VA = "0x180926EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6011457")]
			[Address(RVA = "0x926F90", Offset = "0x925B90", VA = "0x180926F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06011458 RID: 70744 RVA: 0x0006A728 File Offset: 0x00068928
		[Token(Token = "0x1700262A")]
		public bool hasOnBBVariableChangedEvent
		{
			[Token(Token = "0x6011458")]
			[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06011459 RID: 70745 RVA: 0x0006A740 File Offset: 0x00068940
		// (set) Token: 0x0601145A RID: 70746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700262B")]
		public uint instanceUid
		{
			[Token(Token = "0x6011459")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x601145A")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0601145B RID: 70747 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601145C RID: 70748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700262C")]
		public string key
		{
			[Token(Token = "0x601145B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601145C")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0601145D RID: 70749 RVA: 0x0006A758 File Offset: 0x00068958
		// (set) Token: 0x0601145E RID: 70750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700262D")]
		public ParamRealType realType
		{
			[Token(Token = "0x601145D")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			[CompilerGenerated]
			get
			{
				return ParamRealType.Invalid;
			}
			[Token(Token = "0x601145E")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0601145F RID: 70751 RVA: 0x0006A770 File Offset: 0x00068970
		// (set) Token: 0x06011460 RID: 70752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700262E")]
		public ParamValueType valueType
		{
			[Token(Token = "0x601145F")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			[CompilerGenerated]
			get
			{
				return ParamValueType.Invalid;
			}
			[Token(Token = "0x6011460")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06011461 RID: 70753
		[Token(Token = "0x1700262F")]
		public abstract Type type { [Token(Token = "0x6011461")] get; }

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06011462 RID: 70754
		// (set) Token: 0x06011463 RID: 70755
		[Token(Token = "0x17002630")]
		public abstract object rawValue { [Token(Token = "0x6011462")] get; [Token(Token = "0x6011463")] set; }

		// Token: 0x06011464 RID: 70756
		[Token(Token = "0x6011464")]
		public abstract void RawSetValue(ParamVariable other);

		// Token: 0x06011465 RID: 70757
		[Token(Token = "0x6011465")]
		public abstract ParamVariable Copy();

		// Token: 0x06011466 RID: 70758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011466")]
		[Address(RVA = "0x926B40", Offset = "0x925740", VA = "0x180926B40", Slot = "9")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x06011467 RID: 70759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011467")]
		[Address(RVA = "0x926B20", Offset = "0x925720", VA = "0x180926B20")]
		public void InvokeOnBBVariableChangedEvent(ParamVariable oldVar, ParamVariable newVar)
		{
		}

		// Token: 0x06011468 RID: 70760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011468")]
		[Address(RVA = "0x926C00", Offset = "0x925800", VA = "0x180926C00")]
		public void SetupOnBBVariableChangedEventForLevelScript(string scriptPtr, string key)
		{
		}

		// Token: 0x06011469 RID: 70761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011469")]
		[Address(RVA = "0x926BF0", Offset = "0x9257F0", VA = "0x180926BF0")]
		public void SetUpOnTempValueChangedEventForUI(Action<ParamVariable, ParamVariable> fuction)
		{
		}

		// Token: 0x0601146A RID: 70762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601146A")]
		[Address(RVA = "0x926CC0", Offset = "0x9258C0", VA = "0x180926CC0")]
		private void _RaiseOnBBVariableChangedEvent(ParamVariable oldVar, ParamVariable newVar)
		{
		}

		// Token: 0x0601146B RID: 70763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601146B")]
		[Address(RVA = "0x926AE0", Offset = "0x9256E0", VA = "0x180926AE0", Slot = "10")]
		protected virtual void Clear()
		{
		}

		// Token: 0x0601146C RID: 70764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601146C")]
		[Address(RVA = "0x926BB0", Offset = "0x9257B0", VA = "0x180926BB0")]
		public void OnRecycle()
		{
		}

		// Token: 0x0601146D RID: 70765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601146D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ParamVariable()
		{
		}

		// Token: 0x040134D1 RID: 79057
		[Token(Token = "0x40134D1")]
		[FieldOffset(Offset = "0x10")]
		private string m_scriptPtr;

		// Token: 0x040134D2 RID: 79058
		[Token(Token = "0x40134D2")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x040134D3 RID: 79059
		[Token(Token = "0x40134D3")]
		[FieldOffset(Offset = "0x18")]
		private string m_key;
	}
}
