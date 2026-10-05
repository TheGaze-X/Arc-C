using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A4D RID: 27213
	[Token(Token = "0x2006A4D")]
	public class MixStoryAVGAdapter : ExecutorComponent
	{
		// Token: 0x06026E4E RID: 159310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E4E")]
		[Address(RVA = "0x21FB8F0", Offset = "0x21FA4F0", VA = "0x1821FB8F0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06026E4F RID: 159311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E4F")]
		[Address(RVA = "0x21FB890", Offset = "0x21FA490", VA = "0x1821FB890", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06026E50 RID: 159312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E50")]
		[Address(RVA = "0x21FBB30", Offset = "0x21FA730", VA = "0x1821FBB30")]
		private void Start()
		{
		}

		// Token: 0x06026E51 RID: 159313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E51")]
		[Address(RVA = "0x21FBA80", Offset = "0x21FA680", VA = "0x1821FBA80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06026E52 RID: 159314 RVA: 0x000CC9A8 File Offset: 0x000CABA8
		[Token(Token = "0x6026E52")]
		[Address(RVA = "0x21FBBE0", Offset = "0x21FA7E0", VA = "0x1821FBBE0")]
		private bool _ExecuteFocusStoryline(Command command)
		{
			return default(bool);
		}

		// Token: 0x06026E53 RID: 159315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E53")]
		[Address(RVA = "0x21FBD60", Offset = "0x21FA960", VA = "0x1821FBD60")]
		public MixStoryAVGAdapter()
		{
		}

		// Token: 0x0403700E RID: 225294
		[Token(Token = "0x403700E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StageStateBean _stageStateBean;

		// Token: 0x0403700F RID: 225295
		[Token(Token = "0x403700F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x04037010 RID: 225296
		[Token(Token = "0x4037010")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04037011 RID: 225297
		[Token(Token = "0x4037011")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04037012 RID: 225298
		[Token(Token = "0x4037012")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04037013 RID: 225299
		[Token(Token = "0x4037013")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteFocusStoryline;

		// Token: 0x04037014 RID: 225300
		[Token(Token = "0x4037014")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
