using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Serializable]
	public class AnimationTriggers
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000001")]
		public string normalTrigger
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000002")]
		public string highlightedTrigger
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000003")]
		public string pressedTrigger
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		public string selectedTrigger
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000005")]
		public string disabledTrigger
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5A06530", Offset = "0x5A05130", VA = "0x185A06530")]
		public AnimationTriggers()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		private const string kDefaultNormalAnimName = "Normal";

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		private const string kDefaultHighlightedAnimName = "Highlighted";

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		private const string kDefaultPressedAnimName = "Pressed";

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		private const string kDefaultSelectedAnimName = "Selected";

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		private const string kDefaultDisabledAnimName = "Disabled";

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("normalTrigger")]
		[SerializeField]
		private string m_NormalTrigger;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("highlightedTrigger")]
		[SerializeField]
		private string m_HighlightedTrigger;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("pressedTrigger")]
		private string m_PressedTrigger;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("m_HighlightedTrigger")]
		private string m_SelectedTrigger;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("disabledTrigger")]
		private string m_DisabledTrigger;
	}
}
