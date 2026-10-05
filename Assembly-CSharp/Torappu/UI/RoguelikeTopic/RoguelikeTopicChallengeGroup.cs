using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044AD RID: 17581
	[Token(Token = "0x20044AD")]
	public abstract class RoguelikeTopicChallengeGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ADB7 RID: 110007
		[Token(Token = "0x601ADB7")]
		public abstract void Render(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext);

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0601ADB8 RID: 110008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ADB9 RID: 110009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FBF")]
		public virtual Action<float> eventOnGroupSwitch
		{
			[Token(Token = "0x601ADB8")]
			[Address(RVA = "0x1403FA0", Offset = "0x1402BA0", VA = "0x181403FA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601ADB9")]
			[Address(RVA = "0x1404000", Offset = "0x1402C00", VA = "0x181404000", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ADBA RID: 110010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADBA")]
		[Address(RVA = "0x1403F40", Offset = "0x1402B40", VA = "0x181403F40")]
		protected RoguelikeTopicChallengeGroup()
		{
		}

		// Token: 0x04022670 RID: 140912
		[Token(Token = "0x4022670")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnGroupSwitch;

		// Token: 0x04022671 RID: 140913
		[Token(Token = "0x4022671")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnGroupSwitch;

		// Token: 0x04022672 RID: 140914
		[Token(Token = "0x4022672")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
