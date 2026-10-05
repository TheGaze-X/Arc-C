using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002844 RID: 10308
	[Token(Token = "0x2002844")]
	public class ActionHeader : LevelScriptNodeBase
	{
		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06011296 RID: 70294 RVA: 0x00069A20 File Offset: 0x00067C20
		[Token(Token = "0x170025D3")]
		public virtual uint keyEnumFilter
		{
			[Token(Token = "0x6011296")]
			[Address(RVA = "0x906E20", Offset = "0x905A20", VA = "0x180906E20", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06011297 RID: 70295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025D4")]
		public virtual string keyFilter
		{
			[Token(Token = "0x6011297")]
			[Address(RVA = "0x906E80", Offset = "0x905A80", VA = "0x180906E80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06011298 RID: 70296 RVA: 0x00069A38 File Offset: 0x00067C38
		[Token(Token = "0x6011298")]
		[Address(RVA = "0x906B30", Offset = "0x905730", VA = "0x180906B30")]
		public bool DoProcess(EventParams executorParams)
		{
			return default(bool);
		}

		// Token: 0x06011299 RID: 70297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011299")]
		[Address(RVA = "0x906AA0", Offset = "0x9056A0", VA = "0x180906AA0", Slot = "8")]
		public virtual void CollectParams(ref List<IParamBindable> paramList)
		{
		}

		// Token: 0x0601129A RID: 70298 RVA: 0x00069A50 File Offset: 0x00067C50
		[Token(Token = "0x601129A")]
		[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10", Slot = "9")]
		protected virtual bool Process(ParamBlackboard eventContext)
		{
			return default(bool);
		}

		// Token: 0x0601129B RID: 70299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601129B")]
		[Address(RVA = "0x906C90", Offset = "0x905890", VA = "0x180906C90", Slot = "10")]
		public virtual void OnAfterLevelScriptTriggerRegistered(string scriptPtr, ActionContext scriptContext)
		{
		}

		// Token: 0x0601129C RID: 70300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601129C")]
		[Address(RVA = "0x906D80", Offset = "0x905980", VA = "0x180906D80")]
		public ActionHeader()
		{
		}

		// Token: 0x04013386 RID: 78726
		[Token(Token = "0x4013386")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public int nextId;

		// Token: 0x04013387 RID: 78727
		[Token(Token = "0x4013387")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Param<bool> _validate;

		// Token: 0x04013389 RID: 78729
		[Token(Token = "0x4013389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_keyEnumFilter;

		// Token: 0x0401338A RID: 78730
		[Token(Token = "0x401338A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_keyFilter;

		// Token: 0x0401338B RID: 78731
		[Token(Token = "0x401338B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoProcess;

		// Token: 0x0401338C RID: 78732
		[Token(Token = "0x401338C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CollectParams;

		// Token: 0x0401338D RID: 78733
		[Token(Token = "0x401338D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Process;

		// Token: 0x0401338E RID: 78734
		[Token(Token = "0x401338E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAfterLevelScriptTriggerRegistered;

		// Token: 0x0401338F RID: 78735
		[Token(Token = "0x401338F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
