using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DDE RID: 19934
	[Token(Token = "0x2004DDE")]
	public class NameCardV2ShareMedalStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCDE RID: 122078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCDE")]
		[Address(RVA = "0x1766DE0", Offset = "0x17659E0", VA = "0x181766DE0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCDF RID: 122079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCDF")]
		[Address(RVA = "0x1766F30", Offset = "0x1765B30", VA = "0x181766F30")]
		public NameCardV2ShareMedalStartLayoutElement()
		{
		}

		// Token: 0x04027777 RID: 161655
		[Token(Token = "0x4027777")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _diyMedalGroup;

		// Token: 0x04027778 RID: 161656
		[Token(Token = "0x4027778")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _suitMedalGroup;

		// Token: 0x04027779 RID: 161657
		[Token(Token = "0x4027779")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402777A RID: 161658
		[Token(Token = "0x402777A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DDF RID: 19935
		[Token(Token = "0x2004DDF")]
		public class NameCardV2ShareMedalModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DCE0 RID: 122080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCE0")]
			[Address(RVA = "0x1766920", Offset = "0x1765520", VA = "0x181766920")]
			public void InitCollector(NameCardV2ShareMedalStartLayoutElement closure)
			{
			}

			// Token: 0x170045F7 RID: 17911
			// (get) Token: 0x0601DCE1 RID: 122081 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCE2 RID: 122082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F7")]
			public CrossAppShareDynAssetBaseModel diyMedalGroup
			{
				[Token(Token = "0x601DCE1")]
				[Address(RVA = "0x1766A00", Offset = "0x1765600", VA = "0x181766A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCE2")]
				[Address(RVA = "0x1766AC0", Offset = "0x17656C0", VA = "0x181766AC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045F8 RID: 17912
			// (get) Token: 0x0601DCE3 RID: 122083 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCE4 RID: 122084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F8")]
			public CrossAppShareDynAssetBaseModel suitMedalGroup
			{
				[Token(Token = "0x601DCE3")]
				[Address(RVA = "0x1766A60", Offset = "0x1765660", VA = "0x181766A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCE4")]
				[Address(RVA = "0x1766B40", Offset = "0x1765740", VA = "0x181766B40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCE5 RID: 122085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCE5")]
			[Address(RVA = "0x1766750", Offset = "0x1765350", VA = "0x181766750", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCE6 RID: 122086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCE6")]
			[Address(RVA = "0x17669A0", Offset = "0x17655A0", VA = "0x1817669A0")]
			public NameCardV2ShareMedalModelCollector()
			{
			}

			// Token: 0x0402777B RID: 161659
			[Token(Token = "0x402777B")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareMedalStartLayoutElement m_closure;

			// Token: 0x0402777E RID: 161662
			[Token(Token = "0x402777E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x0402777F RID: 161663
			[Token(Token = "0x402777F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_diyMedalGroup;

			// Token: 0x04027780 RID: 161664
			[Token(Token = "0x4027780")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_diyMedalGroup;

			// Token: 0x04027781 RID: 161665
			[Token(Token = "0x4027781")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_suitMedalGroup;

			// Token: 0x04027782 RID: 161666
			[Token(Token = "0x4027782")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_suitMedalGroup;

			// Token: 0x04027783 RID: 161667
			[Token(Token = "0x4027783")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027784 RID: 161668
			[Token(Token = "0x4027784")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
