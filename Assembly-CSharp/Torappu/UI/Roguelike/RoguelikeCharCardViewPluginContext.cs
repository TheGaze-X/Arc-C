using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200547B RID: 21627
	[Token(Token = "0x200547B")]
	public abstract class RoguelikeCharCardViewPluginContext : MonoBehaviour, IRoguelikeCharCardViewPluginContext, IHotfixable
	{
		// Token: 0x0601FD4B RID: 130379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD4B")]
		[Address(RVA = "0x19EAE30", Offset = "0x19E9A30", VA = "0x1819EAE30", Slot = "6")]
		public IRoguelikeCharCardPlugin ConstructPlugin()
		{
			return null;
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x0601FD4C RID: 130380 RVA: 0x000B3700 File Offset: 0x000B1900
		[Token(Token = "0x17004AA4")]
		public virtual RoguelikeCharCardViewPluginPriority pluginPriority
		{
			[Token(Token = "0x601FD4C")]
			[Address(RVA = "0x19EA700", Offset = "0x19E9300", VA = "0x1819EA700", Slot = "15")]
			get
			{
				return RoguelikeCharCardViewPluginPriority.HIGHEST;
			}
		}

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x0601FD4D RID: 130381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AA5")]
		public virtual List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x601FD4D")]
			[Address(RVA = "0x19E7FF0", Offset = "0x19E6BF0", VA = "0x1819E7FF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FD4E RID: 130382 RVA: 0x000B3718 File Offset: 0x000B1918
		[Token(Token = "0x601FD4E")]
		[Address(RVA = "0x19EAD90", Offset = "0x19E9990", VA = "0x1819EAD90", Slot = "17")]
		public virtual bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FD4F RID: 130383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD4F")]
		[Address(RVA = "0x19EAF70", Offset = "0x19E9B70", VA = "0x1819EAF70", Slot = "18")]
		public virtual RoguelikeMenuButtonPluginBase GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
			return null;
		}

		// Token: 0x0601FD50 RID: 130384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD50")]
		[Address(RVA = "0x19EB0B0", Offset = "0x19E9CB0", VA = "0x1819EB0B0", Slot = "19")]
		public virtual RoguelikeSquadStartBattleButtonPluginBase GetCustomSquadStartBattleButtonPlugin()
		{
			return null;
		}

		// Token: 0x0601FD51 RID: 130385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD51")]
		[Address(RVA = "0x19EB110", Offset = "0x19E9D10", VA = "0x1819EB110", Slot = "20")]
		public virtual RoguelikeSelectCharStashTicketButtonBase GetCustomStashTicketButtonPlugin()
		{
			return null;
		}

		// Token: 0x0601FD52 RID: 130386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD52")]
		[Address(RVA = "0x19EB040", Offset = "0x19E9C40", VA = "0x1819EB040", Slot = "21")]
		public virtual UIGuidebookTrigger GetCustomSelectCharGuideBookTriggerAsset(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601FD53 RID: 130387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD53")]
		[Address(RVA = "0x19EAFE0", Offset = "0x19E9BE0", VA = "0x1819EAFE0", Slot = "22")]
		public virtual string GetCustomSelectCharGuideBookSubSignal()
		{
			return null;
		}

		// Token: 0x0601FD54 RID: 130388 RVA: 0x000B3730 File Offset: 0x000B1930
		[Token(Token = "0x601FD54")]
		[Address(RVA = "0x19EB170", Offset = "0x19E9D70", VA = "0x1819EB170", Slot = "23")]
		public virtual bool OverrideSquadTroopCount(List<RoguelikeCharCardViewModel> curCharInSquad, out int squadTroopCount)
		{
			return default(bool);
		}

		// Token: 0x0601FD55 RID: 130389
		[Token(Token = "0x601FD55")]
		public abstract IRoguelikeCharCardPlugin GetPlugin();

		// Token: 0x0601FD56 RID: 130390
		[Token(Token = "0x601FD56")]
		public abstract void LoadData(string topicId);

		// Token: 0x0601FD57 RID: 130391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD57")]
		[Address(RVA = "0x19EB200", Offset = "0x19E9E00", VA = "0x1819EB200")]
		protected RoguelikeCharCardViewPluginContext()
		{
		}

		// Token: 0x0402AE12 RID: 175634
		[Token(Token = "0x402AE12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConstructPlugin;

		// Token: 0x0402AE13 RID: 175635
		[Token(Token = "0x402AE13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pluginPriority;

		// Token: 0x0402AE14 RID: 175636
		[Token(Token = "0x402AE14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_additionalComparers;

		// Token: 0x0402AE15 RID: 175637
		[Token(Token = "0x402AE15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckCharSelectValid;

		// Token: 0x0402AE16 RID: 175638
		[Token(Token = "0x402AE16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCustomPendingEventSelectMenuPlugin;

		// Token: 0x0402AE17 RID: 175639
		[Token(Token = "0x402AE17")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCustomSquadStartBattleButtonPlugin;

		// Token: 0x0402AE18 RID: 175640
		[Token(Token = "0x402AE18")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCustomStashTicketButtonPlugin;

		// Token: 0x0402AE19 RID: 175641
		[Token(Token = "0x402AE19")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCustomSelectCharGuideBookTriggerAsset;

		// Token: 0x0402AE1A RID: 175642
		[Token(Token = "0x402AE1A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCustomSelectCharGuideBookSubSignal;

		// Token: 0x0402AE1B RID: 175643
		[Token(Token = "0x402AE1B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OverrideSquadTroopCount;

		// Token: 0x0402AE1C RID: 175644
		[Token(Token = "0x402AE1C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
