#import "SWGRank.h"

@implementation SWGRank

- (instancetype)init {
  self = [super init];
  if (self) {
    // initialize property's default value, if any
    
  }
  return self;
}


/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper {
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"_iD": @"ID", @"user": @"User", @"style": @"Style", @"mode": @"Mode", @"game": @"Game", @"rank": @"Rank", @"skill": @"Skill", @"placement": @"Placement" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"_iD", @"user", @"style", @"mode", @"game", @"rank", @"skill", @"placement"];
  return [optionalProperties containsObject:propertyName];
}

@end
