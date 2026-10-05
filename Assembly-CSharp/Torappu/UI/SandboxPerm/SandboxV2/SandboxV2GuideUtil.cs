using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043AA RID: 17322
	[Token(Token = "0x20043AA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2GuideUtil
	{
		// Token: 0x0601A93D RID: 108861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A93D")]
		[Address(RVA = "0x13AAED0", Offset = "0x13A9AD0", VA = "0x1813AAED0")]
		private static IEnumerable<PlayerSandboxV2.QuestGroup.Quest> _IterSandboxV2GuideQuest(string topicId, bool isTutorial)
		{
			return null;
		}

		// Token: 0x0601A93E RID: 108862 RVA: 0x000A2678 File Offset: 0x000A0878
		[Token(Token = "0x601A93E")]
		[Address(RVA = "0x13A9CE0", Offset = "0x13A88E0", VA = "0x1813A9CE0")]
		public static bool EnsureSandboxV2GuideQuest(string topicId, string questId, bool isTutorial)
		{
			return default(bool);
		}

		// Token: 0x0601A93F RID: 108863 RVA: 0x000A2690 File Offset: 0x000A0890
		[Token(Token = "0x601A93F")]
		[Address(RVA = "0x13AAFA0", Offset = "0x13A9BA0", VA = "0x1813AAFA0")]
		private static bool _TriggerSandboxV2GuideQuest(SandboxV2Data topicDetailData, string questId, bool isTutorial, bool isPlayerInRift, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0601A940 RID: 108864 RVA: 0x000A26A8 File Offset: 0x000A08A8
		[Token(Token = "0x601A940")]
		[Address(RVA = "0x13A9B00", Offset = "0x13A8700", VA = "0x1813A9B00")]
		public static bool CheckSandboxV2GuideQuest(string topicId, string questId, bool isTutorial)
		{
			return default(bool);
		}

		// Token: 0x0601A941 RID: 108865 RVA: 0x000A26C0 File Offset: 0x000A08C0
		[Token(Token = "0x601A941")]
		[Address(RVA = "0x13AA1E0", Offset = "0x13A8DE0", VA = "0x1813AA1E0")]
		public static bool HasSandboxV2GuideQuest(string topicId, IList<string> questIdList, bool isTutorial)
		{
			return default(bool);
		}

		// Token: 0x0601A942 RID: 108866 RVA: 0x000A26D8 File Offset: 0x000A08D8
		[Token(Token = "0x601A942")]
		[Address(RVA = "0x13AAAF0", Offset = "0x13A96F0", VA = "0x1813AAAF0")]
		public static bool TriggerSandboxV2GuideQuest(string topicId, string questId, bool isTutorial, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0601A943 RID: 108867 RVA: 0x000A26F0 File Offset: 0x000A08F0
		[Token(Token = "0x601A943")]
		[Address(RVA = "0x13AA770", Offset = "0x13A9370", VA = "0x1813AA770")]
		public static bool TriggerSandboxV2GuideQuest(string topicId, IList<string> questIdList, bool isTutorial, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0601A944 RID: 108868 RVA: 0x000A2708 File Offset: 0x000A0908
		[Token(Token = "0x601A944")]
		[Address(RVA = "0x13AADD0", Offset = "0x13A99D0", VA = "0x1813AADD0")]
		public static bool TriggerSandboxV2TutorialGuideQuest(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601A945 RID: 108869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A945")]
		[Address(RVA = "0x13A9ED0", Offset = "0x13A8AD0", VA = "0x1813A9ED0")]
		public static List<string> GetSandboxV2AvgStatus(string topicId)
		{
			return null;
		}

		// Token: 0x0601A946 RID: 108870 RVA: 0x000A2720 File Offset: 0x000A0920
		[Token(Token = "0x601A946")]
		[Address(RVA = "0x13AA470", Offset = "0x13A9070", VA = "0x1813AA470")]
		public static bool SandboxV2AvgToTrigger(out StoryData storyToTrig)
		{
			return default(bool);
		}

		// Token: 0x04021DD8 RID: 138712
		[Token(Token = "0x4021DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__IterSandboxV2GuideQuest;

		// Token: 0x04021DD9 RID: 138713
		[Token(Token = "0x4021DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnsureSandboxV2GuideQuest;

		// Token: 0x04021DDA RID: 138714
		[Token(Token = "0x4021DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TriggerSandboxV2GuideQuest;

		// Token: 0x04021DDB RID: 138715
		[Token(Token = "0x4021DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckSandboxV2GuideQuest;

		// Token: 0x04021DDC RID: 138716
		[Token(Token = "0x4021DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HasSandboxV2GuideQuest;

		// Token: 0x04021DDD RID: 138717
		[Token(Token = "0x4021DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TriggerSandboxV2GuideQuest;

		// Token: 0x04021DDE RID: 138718
		[Token(Token = "0x4021DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_TriggerSandboxV2GuideQuest;

		// Token: 0x04021DDF RID: 138719
		[Token(Token = "0x4021DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerSandboxV2TutorialGuideQuest;

		// Token: 0x04021DE0 RID: 138720
		[Token(Token = "0x4021DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetSandboxV2AvgStatus;

		// Token: 0x04021DE1 RID: 138721
		[Token(Token = "0x4021DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SandboxV2AvgToTrigger;
	}
}
