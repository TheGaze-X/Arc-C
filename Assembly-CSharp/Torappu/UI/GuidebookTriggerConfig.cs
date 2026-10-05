using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200370A RID: 14090
	[Token(Token = "0x200370A")]
	[CreateAssetMenu(menuName = "Torappu/UI/GuideBookTrigger")]
	public class GuidebookTriggerConfig : ScriptableObject
	{
		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x060165D5 RID: 91605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035AC")]
		public string[] pageIds
		{
			[Token(Token = "0x60165D5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x060165D6 RID: 91606 RVA: 0x00090C90 File Offset: 0x0008EE90
		[Token(Token = "0x170035AD")]
		public UIGuideTarget autoShowTarget
		{
			[Token(Token = "0x60165D6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return UIGuideTarget.NONE;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x060165D7 RID: 91607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035AE")]
		public string subsignal
		{
			[Token(Token = "0x60165D7")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060165D8 RID: 91608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165D8")]
		[Address(RVA = "0xEC2A50", Offset = "0xEC1650", VA = "0x180EC2A50")]
		public GuidebookTriggerConfig()
		{
		}

		// Token: 0x0401AE77 RID: 110199
		[Token(Token = "0x401AE77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _pageIds;

		// Token: 0x0401AE78 RID: 110200
		[Token(Token = "0x401AE78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Target to trigger auto show, NONE for always don't auto show")]
		private UIGuideTarget _autoShowTarget;

		// Token: 0x0401AE79 RID: 110201
		[Token(Token = "0x401AE79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Extra signal used to check if targe matches (ignore case)")]
		private string _subsignal;
	}
}
