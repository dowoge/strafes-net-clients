#import "SWGTime.h"

@implementation SWGTime

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"_iD": @"ID", @"time": @"Time", @"user": @"User", @"map": @"Map", @"date": @"Date", @"style": @"Style", @"mode": @"Mode", @"game": @"Game" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"_iD", @"time", @"user", @"map", @"date", @"style", @"mode", @"game"];
  return [optionalProperties containsObject:propertyName];
}

@end
