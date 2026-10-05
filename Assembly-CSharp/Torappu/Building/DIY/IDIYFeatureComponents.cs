using System;
using Il2CppDummyDll;
using Torappu.Building.UI;

namespace Torappu.Building.DIY
{
	// Token: 0x0200184B RID: 6219
	[Token(Token = "0x200184B")]
	public interface IDIYFeatureComponents
	{
		// Token: 0x06009D3D RID: 40253
		[Token(Token = "0x6009D3D")]
		bool Init();

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06009D3E RID: 40254
		[Token(Token = "0x17001151")]
		IFurnitureManager furnitureManager { [Token(Token = "0x6009D3E")] get; }

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06009D3F RID: 40255
		[Token(Token = "0x17001152")]
		IDIYRoomModifierManager modifierManager { [Token(Token = "0x6009D3F")] get; }

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06009D40 RID: 40256
		[Token(Token = "0x17001153")]
		IDIYRoomInfoProvider roomInfoManager { [Token(Token = "0x6009D40")] get; }

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06009D41 RID: 40257
		[Token(Token = "0x17001154")]
		IDIYPresetManager presetManager { [Token(Token = "0x6009D41")] get; }

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06009D42 RID: 40258
		[Token(Token = "0x17001155")]
		IDIYShop shop { [Token(Token = "0x6009D42")] get; }

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06009D43 RID: 40259
		[Token(Token = "0x17001156")]
		IFurnitureStorage storage { [Token(Token = "0x6009D43")] get; }

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06009D44 RID: 40260
		[Token(Token = "0x17001157")]
		IFurnitureSaver saver { [Token(Token = "0x6009D44")] get; }

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06009D45 RID: 40261
		[Token(Token = "0x17001158")]
		IFurnitureTypeDB furnitureTypeDB { [Token(Token = "0x6009D45")] get; }

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06009D46 RID: 40262
		[Token(Token = "0x17001159")]
		IFurnitureDataProvider furnitureDataProvider { [Token(Token = "0x6009D46")] get; }

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06009D47 RID: 40263
		[Token(Token = "0x1700115A")]
		IDIYRoomModifierDataProvider modifierDataProvider { [Token(Token = "0x6009D47")] get; }

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06009D48 RID: 40264
		[Token(Token = "0x1700115B")]
		IFurnitureGroupDataProvider furnitureGroupDatabase { [Token(Token = "0x6009D48")] get; }
	}
}
