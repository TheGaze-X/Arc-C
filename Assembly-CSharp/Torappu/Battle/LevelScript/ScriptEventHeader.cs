using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002846 RID: 10310
	[Token(Token = "0x2002846")]
	public abstract class ScriptEventHeader : ActionHeader
	{
		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x060112A3 RID: 70307 RVA: 0x00069A98 File Offset: 0x00067C98
		[Token(Token = "0x170025D8")]
		public ScriptEventHeader.TriggerTarget triggerTarget
		{
			[Token(Token = "0x60112A3")]
			[Address(RVA = "0x91A5B0", Offset = "0x9191B0", VA = "0x18091A5B0")]
			get
			{
				return ScriptEventHeader.TriggerTarget.SELF;
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x060112A4 RID: 70308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025D9")]
		public virtual string targetScript
		{
			[Token(Token = "0x60112A4")]
			[Address(RVA = "0x91A530", Offset = "0x919130", VA = "0x18091A530", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060112A5 RID: 70309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A5")]
		[Address(RVA = "0x91A430", Offset = "0x919030", VA = "0x18091A430", Slot = "8")]
		public override void CollectParams(ref List<IParamBindable> paramList)
		{
		}

		// Token: 0x060112A6 RID: 70310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A6")]
		[Address(RVA = "0x91A4D0", Offset = "0x9190D0", VA = "0x18091A4D0")]
		protected ScriptEventHeader()
		{
		}

		// Token: 0x060112A7 RID: 70311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A7")]
		[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
		private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
		{
		}

		// Token: 0x04013393 RID: 78739
		[Token(Token = "0x4013393")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[JsonProperty(DefaultValueHandling = 3, Order = -70)]
		[SerializeField]
		[DefaultValue(ScriptEventHeader.TriggerTarget.SELF)]
		public ScriptEventHeader.TriggerTarget _triggerTarget;

		// Token: 0x04013394 RID: 78740
		[Token(Token = "0x4013394")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty(Order = -70)]
		[SerializeField]
		public Param<string> _targetScript;

		// Token: 0x04013395 RID: 78741
		[Token(Token = "0x4013395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_triggerTarget;

		// Token: 0x04013396 RID: 78742
		[Token(Token = "0x4013396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetScript;

		// Token: 0x04013397 RID: 78743
		[Token(Token = "0x4013397")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CollectParams;

		// Token: 0x04013398 RID: 78744
		[Token(Token = "0x4013398")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002847 RID: 10311
		[Token(Token = "0x2002847")]
		public enum TriggerTarget
		{
			// Token: 0x0401339A RID: 78746
			[Token(Token = "0x401339A")]
			SELF,
			// Token: 0x0401339B RID: 78747
			[Token(Token = "0x401339B")]
			SPECIFY_SCRIPT
		}
	}
}
