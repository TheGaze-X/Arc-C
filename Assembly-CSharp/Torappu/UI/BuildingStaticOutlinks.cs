using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020036C1 RID: 14017
	[Token(Token = "0x20036C1")]
	[CreateAssetMenu(menuName = "Torappu/UI/BuildingStaticOutlinks")]
	[Serializable]
	public class BuildingStaticOutlinks : ScriptableObject
	{
		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0601645D RID: 91229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700357C")]
		public BuildingGlobalNotificationHolder globalNotifyViewHolder
		{
			[Token(Token = "0x601645D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0601645E RID: 91230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700357D")]
		public BuildingUIResMenu resMenu
		{
			[Token(Token = "0x601645E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0601645F RID: 91231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700357E")]
		public Image levelIcon
		{
			[Token(Token = "0x601645F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x06016460 RID: 91232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700357F")]
		public BuildingBuffedValueView buffView
		{
			[Token(Token = "0x6016460")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x06016461 RID: 91233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003580")]
		public BuildingCharAvatar charAvatar
		{
			[Token(Token = "0x6016461")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x06016462 RID: 91234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003581")]
		public BuildingCharMPStateBar charMapBar
		{
			[Token(Token = "0x6016462")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x06016463 RID: 91235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003582")]
		public BuildingCharSelectRoomConfig config
		{
			[Token(Token = "0x6016463")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x06016464 RID: 91236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003583")]
		public BuildingStaticIconHub iconHub
		{
			[Token(Token = "0x6016464")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016465 RID: 91237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016465")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public BuildingStaticOutlinks()
		{
		}

		// Token: 0x0401AC9F RID: 109727
		[Token(Token = "0x401AC9F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingGlobalNotificationHolder _globalNotifyViewHolder;

		// Token: 0x0401ACA0 RID: 109728
		[Token(Token = "0x401ACA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingUIResMenu _resMenu;

		// Token: 0x0401ACA1 RID: 109729
		[Token(Token = "0x401ACA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _levelIcon;

		// Token: 0x0401ACA2 RID: 109730
		[Token(Token = "0x401ACA2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingBuffedValueView _buffView;

		// Token: 0x0401ACA3 RID: 109731
		[Token(Token = "0x401ACA3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingCharAvatar _charAvatar;

		// Token: 0x0401ACA4 RID: 109732
		[Token(Token = "0x401ACA4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingCharMPStateBar _charMapBar;

		// Token: 0x0401ACA5 RID: 109733
		[Token(Token = "0x401ACA5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuildingCharSelectRoomConfig _config;

		// Token: 0x0401ACA6 RID: 109734
		[Token(Token = "0x401ACA6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingStaticIconHub _iconHub;
	}
}
