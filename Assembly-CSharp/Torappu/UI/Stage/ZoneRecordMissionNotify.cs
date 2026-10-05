using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069CA RID: 27082
	[Token(Token = "0x20069CA")]
	public class ZoneRecordMissionNotify : UINotifyView<ZoneRecordMissionNotify.Param>
	{
		// Token: 0x06026C03 RID: 158723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C03")]
		[Address(RVA = "0x21E0840", Offset = "0x21DF440", VA = "0x1821E0840", Slot = "9")]
		protected override void Render(ZoneRecordMissionNotify.Param param)
		{
		}

		// Token: 0x06026C04 RID: 158724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C04")]
		[Address(RVA = "0x21E0B70", Offset = "0x21DF770", VA = "0x1821E0B70")]
		private void _LoadImage()
		{
		}

		// Token: 0x06026C05 RID: 158725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C05")]
		[Address(RVA = "0x21E0D50", Offset = "0x21DF950", VA = "0x1821E0D50")]
		public ZoneRecordMissionNotify()
		{
		}

		// Token: 0x04036B9F RID: 224159
		[Token(Token = "0x4036B9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04036BA0 RID: 224160
		[Token(Token = "0x4036BA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ZoneRecordMissionNotify.DiffGroup[] _diffGroups;

		// Token: 0x04036BA1 RID: 224161
		[Token(Token = "0x4036BA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _predefinedDiff;

		// Token: 0x04036BA2 RID: 224162
		[Token(Token = "0x4036BA2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ZoneRecordMissionNotify.AtlasImageGroup[] _imageGroups;

		// Token: 0x04036BA3 RID: 224163
		[Token(Token = "0x4036BA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036BA4 RID: 224164
		[Token(Token = "0x4036BA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x04036BA5 RID: 224165
		[Token(Token = "0x4036BA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069CB RID: 27083
		[Token(Token = "0x20069CB")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06026C06 RID: 158726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026C06")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04036BA6 RID: 224166
			[Token(Token = "0x4036BA6")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x04036BA7 RID: 224167
			[Token(Token = "0x4036BA7")]
			[FieldOffset(Offset = "0x18")]
			public StageDiffGroup diff;

			// Token: 0x04036BA8 RID: 224168
			[Token(Token = "0x4036BA8")]
			[FieldOffset(Offset = "0x1C")]
			public bool isPredefined;
		}

		// Token: 0x020069CC RID: 27084
		[Token(Token = "0x20069CC")]
		[Serializable]
		public struct DiffGroup
		{
			// Token: 0x04036BA9 RID: 224169
			[Token(Token = "0x4036BA9")]
			[FieldOffset(Offset = "0x0")]
			public StageDiffGroup diff;

			// Token: 0x04036BAA RID: 224170
			[Token(Token = "0x4036BAA")]
			[FieldOffset(Offset = "0x8")]
			public GameObject icon;
		}

		// Token: 0x020069CD RID: 27085
		[Token(Token = "0x20069CD")]
		[Serializable]
		public struct AtlasImageGroup
		{
			// Token: 0x04036BAB RID: 224171
			[Token(Token = "0x4036BAB")]
			[FieldOffset(Offset = "0x0")]
			public UIAtlasImage image;

			// Token: 0x04036BAC RID: 224172
			[Token(Token = "0x4036BAC")]
			[FieldOffset(Offset = "0x8")]
			public string atlasName;
		}
	}
}
